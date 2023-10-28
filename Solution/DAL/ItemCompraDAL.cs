using Models;

namespace DAL
{
    public class ItemCompraDAL : DALModelo<ItemCompra>
    {
        public ItemCompraDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 1038;
            idExceptionSalvar[Operacao.Alterar] = 1039;
            idExceptionSalvar[Operacao.Excluir] = 1040;
        }
    }
}