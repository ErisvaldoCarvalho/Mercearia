using Models;

namespace BLL
{
    public class MarcaBLL : IBLL
    {
        public void Alterar(IEntidade _entidade)
        {
            throw new NotImplementedException();
        }

        public List<IEntidade> BuscarPorCampo(string _campo, string _valorABuscar)
        {
            throw new NotImplementedException();
        }

        public List<IEntidade> BuscarPorDescricao(string _descricao)
        {
            throw new NotImplementedException();
        }

        public IEntidade BuscarPorId(int _id)
        {
            throw new NotImplementedException();
        }

        public List<IEntidade> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Excluir(int _id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(IEntidade _entidade)
        {
            throw new NotImplementedException();
        }
        public void Salvar(IEntidade _entidade)
        {
            if (_entidade.Id == 0)
                Inserir(_entidade);
            else
                Alterar(_entidade);
        }
    }
}
