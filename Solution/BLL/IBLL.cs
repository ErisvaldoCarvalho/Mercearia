using Models;

namespace BLL
{
    public interface IBLL
    {
        void Inserir(IEntidade _entidade);
        void Alterar(IEntidade _entidade);
        void Excluir(int _id);
        List<IEntidade> BuscarTodos();
        IEntidade BuscarPorId(int _id);
        List<IEntidade> BuscarPorDescricao(string _descricao);
        List<IEntidade> BuscarPorCampo(string _campo, string _valorABuscar);
    }
}