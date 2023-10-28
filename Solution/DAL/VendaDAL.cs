using Models;

namespace DAL
{
    public class VendaDAL : DALModelo<Venda>
    {
        public VendaDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 1060;
            idExceptionSalvar[Operacao.Alterar] = 1061;
            idExceptionSalvar[Operacao.Excluir] = 1062;
        }
    }
}