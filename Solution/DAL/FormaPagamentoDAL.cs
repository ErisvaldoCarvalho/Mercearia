using Models;

namespace DAL
{
    public class FormaPagamentoDAL : DALModelo<FormaPagamento>
    {
        public FormaPagamentoDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 1026;
            idExceptionSalvar[Operacao.Alterar] = 1027;
            idExceptionSalvar[Operacao.Excluir] = 1028;
        }
    }
}