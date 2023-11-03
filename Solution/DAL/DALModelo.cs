using Microsoft.EntityFrameworkCore;
using Models;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace DAL
{
    public class DALModelo<T> where T : new()
    {
        private string nomeTabela;
        protected Dictionary<Operacao, int> idExceptionSalvar;
        public string ScriptInsert { get; set; }
        public string ScriptUpdate { get; set; }
        public string ScriptDelete { get; set; }
        public string ScriptSelect { get; set; }

        public DALModelo()
        {
            var t = new T();

            idExceptionSalvar = new Dictionary<Operacao, int>();

            nomeTabela = typeof(T).Name;
            // Carro.Id, Carro.Nome,  Carro.Placa,  Carro.Chassi) values(@Nome, @Placa, @Chassi)
            ScriptInsert = "INSERT INTO " + nomeTabela + "(" + Campos(t).Replace("Id, ", "") + ") VALUES(@" + Campos(t).Replace("Id, ", "").Replace(", ", ", @") + ")";
            ScriptSelect = "SELECT " + nomeTabela + "." + Campos(t).Replace(", ", ", " + nomeTabela + ".") + " FROM " + nomeTabela;
            ScriptUpdate = UpdateScript(t);
            ScriptDelete = "DELETE FROM " + nomeTabela + " WHERE Id = @Id";
        }
        public enum Operacao
        {
            [Description("inserir")]
            Inserir,

            [Description("alterar")]
            Alterar,

            [Description("excluir")]
            Excluir
        }
        protected string GetEnumDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attribute == null ? value.ToString() : attribute.Description;
        }
        private string UpdateScript(T _objeto)
        {
            Type type = typeof(T);
            PropertyInfo[] propriedades = type.GetProperties();

            StringBuilder campos = new StringBuilder();

            foreach (PropertyInfo item in propriedades)
            {
                if (item.Name != "Id" && !item.PropertyType.Name.Contains("List"))
                {
                    campos.Append(item.Name + " = @" + item.Name);
                    campos.Append(",\n");
                }
            }

            if (campos.Length > 0)
                campos.Length -= 2; // Remove a última vírgula

            return "UPDATE " + nomeTabela + " SET\n" + campos.ToString() + "\nWHERE Id = @Id";
        }
        private string Campos(T _objeto)
        {
            Type type = typeof(T);
            PropertyInfo[] propriedades = type.GetProperties();

            StringBuilder campos = new StringBuilder();

            foreach (PropertyInfo item in propriedades)
            {
                if (!item.PropertyType.Name.Contains("List"))
                {
                    campos.Append(item.Name);
                    campos.Append(", ");
                }
            }

            if (campos.Length > 0)
                campos.Length -= 2; // Remove a última vírgula

            return campos.ToString();
        }
        public void PopularParametros(SqlCommand _cmd, T _objeto)
        {
            _cmd.Parameters.Clear();
            Type type = typeof(T);
            PropertyInfo[] propriedades = type.GetProperties();

            foreach (PropertyInfo item in propriedades)
            {
                if (!item.PropertyType.Name.Contains("List"))
                {
                    object valor = item.GetValue(_objeto);
                    _cmd.Parameters.AddWithValue("@" + item.Name, valor ?? DBNull.Value);
                }
            }
        }
        public void PopularParametrosExclusao(SqlCommand _cmd, T _objeto)
        {
            _cmd.Parameters.Clear();
            PropertyInfo propriedadeId = typeof(T).GetProperty("Id");
            if (propriedadeId != null)
            {
                object valorId = propriedadeId.GetValue(_objeto);
                _cmd.Parameters.AddWithValue("@Id", valorId ?? DBNull.Value);
            }
        }
        public virtual void Salvar(T _t, bool _excluir = false, SqlTransaction _transaction = null)
        {
            if (Constantes.UsarEntityFramework)
                SalvarComEntityFramework(_t, _excluir);
            else
                SalvarComAdoNet(_t, _excluir, _transaction);
        }
        private void SalvarComAdoNet(T _t, bool _excluir, SqlTransaction _transaction)
        {
            SqlTransaction transaction = _transaction;
            PropertyInfo propriedadeId = typeof(T).GetProperty("Id");
            int id = 0;

            if (propriedadeId != null)
            {
                object valorId = propriedadeId.GetValue(_t);
                id = (int)valorId;
            }

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                string script;

                if (_excluir)
                    script = ScriptDelete;
                else if (id != 0)
                    script = ScriptUpdate;
                else
                    script = ScriptInsert;

                using (SqlCommand cmd = new SqlCommand(script, cn))
                {
                    Operacao operacao = id == 0 ? Operacao.Inserir : Operacao.Alterar;

                    if (_excluir)
                        operacao = Operacao.Excluir;

                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        PopularParametros(cmd, _t);

                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction.Connection != null && transaction.Connection.State == System.Data.ConnectionState.Open)
                            transaction.Rollback();

                        throw new Exception("Ocorreu um erro ao tentar " + operacao + " " + Constantes.Verbose(nameof(_t)).ToLower() + " no banco de dados.", ex) { Data = { { "Id", idExceptionSalvar[operacao] } } };
                    }
                }
            }
        }

        private void SalvarComEntityFramework(T _t, bool _excluir = false)
        {
            int id = (int)_t.GetType().GetProperty("Id").GetValue(_t);

            using (DataContext dataContext = new DataContext())
            {
                if (_excluir)
                    dataContext.Remove(_t);
                else if (id == 0)
                    dataContext.Add(_t);
                else
                    dataContext.Update(_t);

                dataContext.SaveChanges();
            }
        }
        public virtual void Excluir(int _id)
        {
            var t = new T();
            var id = t.GetType().GetProperty("Id");

            id.SetValue(t, _id, null);

            Salvar(t, true);
        }
        public virtual List<T> BuscarTodos(SqlCommand _cmd = null)
        {
            if (Constantes.UsarEntityFramework)
            {
                //TODO: Implementar a busca utilizndo Entity Framework aqui
            }
            var tList = new List<T>();
            var t = new T();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = ScriptSelect;
                cmd.CommandType = System.Data.CommandType.Text;

                if (_cmd != null)
                {
                    cmd.CommandText = _cmd.CommandText;
                    cmd.Parameters.Clear();
                    foreach (SqlParameter item in _cmd.Parameters)
                        cmd.Parameters.AddWithValue(item.ParameterName, item.Value);
                }

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        t = PreencherObjeto(rd);
                        tList.Add(t);
                    }
                }
                return tList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar " + Constantes.Verbose(nameof(T)).ToLower() + " no banco de dados.", ex) { Data = { { "Id", 4 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public virtual T BuscarPorId(int _id)
        {
            var t = new T();
            //TODO: Adicionar id no objeto
            return BuscarPorId(t);
        }
        public virtual T BuscarPorId(T _t)
        {
            try
            {
                var id = _t.GetType().GetProperty("Id").GetValue(_t);

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = ScriptSelect + " WHERE " + nameof(_t) + ".Id = @Id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    var tList = BuscarTodos(cmd);
                    return tList[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar " + Constantes.Verbose(nameof(_t)).ToLower() + " por Id no banco de dados.", ex) { Data = { { "Id", 3 } } };
            }
        }
        internal List<T>? BuscarPorFK(object _t)
        {
            var propriedade = _t.GetType().GetProperty("Id");
            var id = propriedade.GetValue(_t);
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = ScriptSelect + " WHERE " + nameof(_t) + "." + nameof(propriedade) + "Id = @" + nameof(_t) + "Id";
                    cmd.Parameters.AddWithValue("@" + nameof(_t) + "Id", id);
                    var tList = BuscarTodos(cmd);
                    return tList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar " + Constantes.Verbose(nameof(_t)).ToLower() + " por " + nameof(_t) + "." + nameof(propriedade) + " no banco de dados.", ex) { Data = { { "Id", 3 } } };
            }
        }
        public virtual List<T>? BuscarPorNomeCampo(string _nomeCampo)
        {
            var t = new T();
            var propriedade = t.GetType().GetProperty(_nomeCampo);
            var campo = propriedade.GetValue(t);
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = ScriptSelect + " WHERE " + nameof(t) + "." + _nomeCampo + " = @" + _nomeCampo;
                    cmd.Parameters.AddWithValue("@" + _nomeCampo, campo);
                    var tList = BuscarTodos(cmd);
                    return tList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar " + Constantes.Verbose(nameof(t)).ToLower() + " por " + nameof(t) + "." + nameof(propriedade) + " no banco de dados.", ex) { Data = { { "Id", 3 } } };
            }
        }
        protected T PreencherObjeto(SqlDataReader _rd)
        {
            var t = new T();

            for (int i = 0; i < _rd.FieldCount; i++)
            {
                string nomeCampo = _rd.GetName(i);
                object valorCampo = _rd.GetValue(i);

                PropertyInfo propriedade = t.GetType().GetProperty(nomeCampo);

                if (propriedade != null && valorCampo != DBNull.Value)
                {
                    // Converte o valor do campo para o tipo da propriedade
                    object valorConvertido = Convert.ChangeType(valorCampo, propriedade.PropertyType);

                    // Define o valor da propriedade
                    propriedade.SetValue(t, valorConvertido);
                    PopularEntidadesRelacionadas(t);
                }
            }

            return t;
        }
        public virtual void PopularEntidadesRelacionadas(T _t)
        {

        }
    }
}