using Models;

namespace DAL
{
    public class CompraDAL : DALModelo<Compra>
    {
        public CompraDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 1010;
            idExceptionSalvar[Operacao.Alterar] = 1011;
            idExceptionSalvar[Operacao.Excluir] = 1012;
        }
    }
}