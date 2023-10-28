using Models;

namespace DAL
{
    public class SubGrupoProdutoDAL : DALModelo<SubGrupoProduto>
    {
        public SubGrupoProdutoDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 1052;
            idExceptionSalvar[Operacao.Alterar] = 1053;
            idExceptionSalvar[Operacao.Excluir] = 1054;
        }
    }
}