using Models;

namespace DAL
{
    public class ClienteDAL : DALModelo<Cliente>
    {
        public ClienteDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 107;
            idExceptionSalvar[Operacao.Alterar] = 108;
            idExceptionSalvar[Operacao.Excluir] = 109;
        }
    }
}