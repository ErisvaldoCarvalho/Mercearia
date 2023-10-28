using Models;

namespace DAL
{
    public class ItemVendaDAL : DALModelo<ItemVenda>
    {
        public ItemVendaDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 1044;
            idExceptionSalvar[Operacao.Alterar] = 1045;
            idExceptionSalvar[Operacao.Excluir] = 1046;
        }
    }
}