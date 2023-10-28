using Models;

namespace DAL
{
    public class ContasAReceberDAL : DALModelo<ContasAReceber>
    {
        public ContasAReceberDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 1014;
            idExceptionSalvar[Operacao.Alterar] = 1015;
            idExceptionSalvar[Operacao.Excluir] = 1016;
        }
    }
}