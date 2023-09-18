using DAL;
using Models;

namespace BLL
{
    public class DepartamentoProdutoBLL
    {
        public void Inserir(DepartamentoProduto _departamentoProduto)
        {
            using (DataContext dataContext = new DataContext())
            {
                dataContext.Add(_departamentoProduto);
                dataContext.SaveChanges();
            }
        }
        public void Alterar(DepartamentoProduto _departamentoProduto)
        {
            using (DataContext dataContext = new DataContext())
            {
                dataContext.Update(_departamentoProduto);
                dataContext.SaveChanges();
            }
        }
        public void Excluir(int _id)
        {
            using (DataContext dataContext = new DataContext())
            {
                dataContext.Remove(BuscarPorId(_id));
                dataContext.SaveChanges();
            }
        }
        public List<DepartamentoProduto> BuscarTodos()
        {
            return new DataContext().DepartamentoProduto.ToList();
        }
        public DepartamentoProduto BuscarPorId(int _id)
        {
            return new DataContext().DepartamentoProduto.Where(item => item.Id == _id).SingleOrDefault();
        }
        public List<DepartamentoProduto> BuscarDescricao(string _descricao)
        {
            return new DataContext().DepartamentoProduto.Where(item => item.Descricao.Contains(_descricao)).ToList();
        }
    }
}
