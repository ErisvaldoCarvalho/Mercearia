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

        public List<IEntidade> BuscarPorDescricao(string _descricao)
        {
            List<IEntidade> lista = new List<IEntidade>();
            
            return lista;
        }

        public IEntidade BuscarPorId(int _id)
        {
            //return new GrupoProduto() { Id = _id, Descricao = "asdf" };
            return new DataContext().GrupoProduto.Where(item => item.Id == _id).SingleOrDefault();
        }

        public List<IEntidade> BuscarTodos()
        {
            return null;
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
