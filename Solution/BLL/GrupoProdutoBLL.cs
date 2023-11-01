using DAL;
using Models;

namespace BLL
{
    public class GrupoProdutoBLL : IBLL
    {
        public void Alterar(IEntidade _entidade)
        {
            using (DataContext dataContext = new DataContext())
            {
                dataContext.Update(_entidade);
                dataContext.SaveChanges();
            }
        }

        public List<IEntidade> BuscarPorCampo(string _campo, string _valorABuscar)
        {
            throw new NotImplementedException();
        }

        public List<IEntidade> BuscarPorDescricao(string _descricao)
        {
            using (var context = new DataContext())
            {
                List<GrupoProduto> listaGrupoProduto = context.GrupoProduto
                                                              .Where(gp => gp.Descricao.Contains(_descricao))
                                                              .ToList();

                List<IEntidade> listaIEntidade = listaGrupoProduto.Cast<IEntidade>().ToList();

                return listaIEntidade;
            }

        }

        public IEntidade BuscarPorId(int _id)
        {
            using (DataContext dataContext = new DataContext())
            {
                return dataContext.GrupoProduto.Where(item => item.Id == _id).SingleOrDefault();
            }
        }

        public List<IEntidade> BuscarTodos()
        {
            using (DataContext dataContext = new DataContext())
            {
                List<GrupoUsuario> grupoUsuarioList = dataContext.GrupoUsuario.ToList();
                return grupoUsuarioList.Cast<IEntidade>().ToList();
            }
        }

        public void Excluir(int _id)
        {
            using (DataContext dataContext = new DataContext())
            {
                dataContext.Remove(dataContext.GrupoProduto.Where(item => item.Id == _id).SingleOrDefault());
                dataContext.SaveChanges();
            }
        }

        public void Inserir(IEntidade _entidade)
        {
            using (DataContext dataContext = new DataContext())
            {
                dataContext.Add(_entidade);
                dataContext.SaveChanges();
            }
        }
    }
}
