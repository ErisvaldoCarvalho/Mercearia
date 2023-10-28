using Models;

namespace DAL
{
    public class ContasAPagarDAL : DALModelo<ContasAPagar>
    {
        public ContasAPagarDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 1017;
            idExceptionSalvar[Operacao.Alterar] = 1018;
            idExceptionSalvar[Operacao.Excluir] = 1019;
        }
    }
}   