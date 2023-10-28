using DAL;
using Models;

namespace BLL
{
    public class CategoriaProdutoBLL
    {
        public void Salvar(CategoriaProduto _categoriaProduto)
        {
            new CategoriaProdutoDAL().Salvar(_categoriaProduto);
        }
        public void Excluir(int _id)
        {
            new CategoriaProdutoDAL().Excluir(_id);
        }
        public List<CategoriaProduto> BuscarTodos()
        {
            return new CategoriaProdutoDAL().BuscarTodos();
        }
        public CategoriaProduto BuscarPorId(int _id)
        {
            return new DataContext().CategoriaProduto.Where(item => item.Id == _id).SingleOrDefault();
        }
        public List<CategoriaProduto> BuscarPorNomeCampo(string _descricao)
        {
            return new CategoriaProdutoDAL().BuscarPorNomeCampo(_descricao);
            //return new DataContext().CategoriaProduto.Where(item => item.Descricao.Contains(_descricao)).ToList();
        }
    }
}
