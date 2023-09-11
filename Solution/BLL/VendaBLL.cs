using DAL;
using Models;

namespace BLL
{
    public class VendaBLL
    {
        public void Alterar(Venda _objeto)
        {
            using (DataContext dataContext = new DataContext())
            {
                dataContext.Add(_objeto);
                dataContext.SaveChanges();
            }
        }

        public Venda? BuscarPorId(int _id)
        {
            return (from venda in new DataContext().Venda
                    where venda.Id == _id
                    select venda).SingleOrDefault();
        }
        public List<Venda> BuscarTodos()
        {
            using (DataContext dataContext = new DataContext())
            {
                return dataContext.Venda.ToList();
            }
        }

        public void Excluir(int _id)
        {
            using (DataContext dataContext = new DataContext())
            {
                var venda = BuscarPorId(_id);
                if (venda != null)
                {
                    dataContext.Remove(venda);
                    dataContext.SaveChanges();
                }
            }
        }

        public void Inserir(Venda _venda)
        {
            using (DataContext dataContext = new DataContext())
            {
                dataContext.Add(_venda);
                dataContext.SaveChanges();
            }
        }
    }
}