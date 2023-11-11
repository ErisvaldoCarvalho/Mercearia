using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            try
            {
                using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Usuario(Nome, NomeUsuario, Senha, Ativo) 
                                                             VALUES(@Nome, @NomeUsuario, @Senha, @Ativo)"))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                        cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                        cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                        cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);

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
                }
            }
            catch (Exception ex)
            {
                if (transaction.Connection != null && transaction.Connection.State == System.Data.ConnectionState.Open)
                    transaction.Rollback();

                throw new Exception("Ocorreu um erro ao tentar inserir um usuário no banco de dados", ex);
            }
        }
        public void Alterar(Usuario _usuario, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            try
            {
                using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
                {
                    using (SqlCommand cmd = new SqlCommand(@"UPDATE Usuario SET
                                                             Nome = @Nome,
                                                             NomeUsuario = @NomeUsuario,
                                                             Senha = @Senha,
                                                             Ativo = @Ativo
                                                             WHERE Id = @Id"))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Id", _usuario.Id);
                        cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                        cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                        cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                        cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);

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
                }
            }
            catch (Exception ex)
            {
                if (transaction.Connection != null && transaction.Connection.State == System.Data.ConnectionState.Open)
                    transaction.Rollback();

                throw new Exception("Ocorreu um erro ao tentar alterar um usuário no banco de dados", ex);
            }
        }
        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            try
            {
                using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
                {
                    using (SqlCommand cmd = new SqlCommand(@"DELETE FROM Usuario WHERE Id = @Id"))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Id", _id);

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
                }
            }
            catch (Exception ex)
            {
                if (transaction.Connection != null && transaction.Connection.State == System.Data.ConnectionState.Open)
                    transaction.Rollback();

                throw new Exception("Ocorreu um erro ao tentar excluir um usuário no banco de dados", ex);
            }
        }
        public List<Usuario> BuscarTodos()
        {
            List<Usuario> usuarioList = new List<Usuario>();
            Usuario usuario;

            try
            {
                using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Nome, NomeUsuario, Senha, Ativo FROM Usuario"))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Connection = cn;

                        cn.Open();

                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                usuario = PreencherObjeto(rd);
                                usuarioList.Add(usuario);
                            }
                        }

                    }
                }
                return usuarioList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar usuário no banco de dados", ex);
            }
        }
        private Usuario PreencherObjeto(SqlDataReader _rd)
        {
            Usuario usuario = new Usuario();
            usuario.Id = (int)_rd["Id"];
            usuario.Nome = _rd["Nome"].ToString();
            usuario.NomeUsuario = _rd["NomeUsuario"].ToString();
            usuario.Senha = _rd["Senha"].ToString();
            usuario.Ativo = Convert.ToBoolean(_rd["Ativo"]);
            return usuario;
        }
        public Usuario BuscarPorId(int _id)
        {
            Usuario usuario = new Usuario();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Nome, NomeUsuario, Senha, Ativo FROM Usuario WHERE Id = @Id"))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Id", _id);
                        cmd.Connection = cn;

                        cn.Open();

                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                                usuario = PreencherObjeto(rd);
                        }
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar usuário por Id no banco de dados", ex);
            }
        }
        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            Usuario usuario = new Usuario();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Nome, NomeUsuario, Senha, Ativo FROM Usuario WHERE NomeUsuario = @NomeUsuario"))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@NomeUsuario", _nomeUsuario);
                        cmd.Connection = cn;

                        cn.Open();

                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                                usuario = PreencherObjeto(rd);
                        }
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar usuário por NomeUsuario no banco de dados", ex);
            }
        }

        public List<Usuario> BuscarPorNome(string _nome)
        {
            List<Usuario> usuarioList = new List<Usuario>();
            Usuario usuario;

            try
            {
                using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Nome, NomeUsuario, Senha, Ativo FROM Usuario WHERE Nome LIKE @Nome"))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");
                        cmd.Connection = cn;

                        cn.Open();

                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                usuario = PreencherObjeto(rd);
                                usuarioList.Add(usuario);
                            }
                        }

                    }
                }
                return usuarioList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar usuário por nome no banco de dados", ex);
            }
        }
    }
}