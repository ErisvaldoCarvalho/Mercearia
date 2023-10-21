using DAL;
using Models;

namespace BLL
{
    public class PermissaoBLL
    {
        public List<Permissao> BuscarTodos()
        {
            using (DataContext dataContext = new DataContext())
            {
                return dataContext.Permissao.ToList();
            }
        }
        public List<Permissao> BuscarPorDescricao(string _descricao)
        {
            using (DataContext dataContext = new DataContext())
            {
                return dataContext.Permissao.Where(item => item.Descricao.Contains(_descricao)).ToList();
            }
        }
    }
}
