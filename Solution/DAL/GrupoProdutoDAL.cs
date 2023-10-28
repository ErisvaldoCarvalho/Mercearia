using Models;

namespace DAL
{
    public class GrupoProdutoDAL : DALModelo<GrupoProduto>
    {
        public GrupoProdutoDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 1032;
            idExceptionSalvar[Operacao.Alterar] = 1033;
            idExceptionSalvar[Operacao.Excluir] = 1034;
        }
    }
}