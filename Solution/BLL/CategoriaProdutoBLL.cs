using DAL;
using Models;
using System.Security.Cryptography;

namespace BLL
{
    public class CategoriaProdutoBLL
    {
        public void Inserir(CategoriaProduto _categoriaProduto)
        {
            using (DataContext dataContext = new DataContext())
            {
                dataContext.Add(_categoriaProduto);
                dataContext.SaveChanges();
            }
        }
        public void Alterar(CategoriaProduto _categoriaProduto)
        {
            using (DataContext dataContext = new DataContext())
            {
                dataContext.Update(_categoriaProduto);
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
        public List<CategoriaProduto> BuscarTodos()
        {
            return new DataContext().CategoriaProduto.ToList();
        }
        public CategoriaProduto BuscarPorId(int _id)
        {
            return new DataContext().CategoriaProduto.Where(item => item.Id == _id).SingleOrDefault();
        }
        public List<CategoriaProduto> BuscarDescricao(string _descricao)
        {
            return new DataContext().CategoriaProduto.Where(item => item.Descricao.Contains(_descricao)).ToList();
        }
    }
}
