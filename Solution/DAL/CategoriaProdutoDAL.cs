using Models;

namespace DAL
{
    public class CategoriaProdutoDAL : DALModelo<CategoriaProduto>
    {
        public CategoriaProdutoDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 104;
            idExceptionSalvar[Operacao.Alterar] = 105;
            idExceptionSalvar[Operacao.Excluir] = 106;
        }
    }
}