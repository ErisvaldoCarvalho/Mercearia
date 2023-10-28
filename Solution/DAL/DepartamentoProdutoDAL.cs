using Models;

namespace DAL
{
    public class DepartamentoProdutoDAL : DALModelo<DepartamentoProduto>
    {
        public DepartamentoProdutoDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 1020;
            idExceptionSalvar[Operacao.Alterar] = 1021;
            idExceptionSalvar[Operacao.Excluir] = 1022;
        }
    }
}