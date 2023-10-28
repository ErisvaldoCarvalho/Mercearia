using Models;

namespace DAL
{
    public class ItemContasAReceberDAL : DALModelo<ItemContasAReceber>
    {
        public ItemContasAReceberDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 1041;
            idExceptionSalvar[Operacao.Alterar] = 1042;
            idExceptionSalvar[Operacao.Excluir] = 1043;
        }
    }
}