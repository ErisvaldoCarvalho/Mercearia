using DAL;
using Models;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        public void Alterar(GrupoUsuario _grupoUsuario)
        {
            using (DataContext dataContext = new DataContext())
            {
                dataContext.Update(_grupoUsuario);
                dataContext.SaveChanges();
            }
        }
        public List<GrupoUsuario> BuscarTodos()
        {
            return new DataContext().GrupoUsuario.ToList();
        }
        public List<GrupoUsuario> BuscarPorDescricao(string _descricao)
        {
            return new DataContext().GrupoUsuario.Where(item => item.Descricao.Contains(_descricao)).ToList();
        }
        public GrupoUsuario BuscarPorId(int _id)
        {
            return new DataContext().GrupoUsuario.Where(item => item.Id == _id).FirstOrDefault();
        }

        public void Inserir(GrupoUsuario _grupoUsuario)
        {
            using (DataContext dataContext = new DataContext())
            {
                dataContext.Add(_grupoUsuario);
                dataContext.SaveChanges();
            }
        }

        public void Excluir(int _id)
        {
            using (DataContext dataContext = new DataContext())
            {
                dataContext.Remove(BuscarPorId(_id));
                dataContext.SaveChanges(true);
            }
        }
    }
}
