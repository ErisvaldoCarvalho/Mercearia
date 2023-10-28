using Models;

namespace DAL
{
    public class ProdutoDAL : DALModelo<Produto>
    {
        public ProdutoDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 101;
            idExceptionSalvar[Operacao.Alterar] = 102;
            idExceptionSalvar[Operacao.Excluir] = 103;
        }
    }
}