using Models;

namespace DAL
{
    public class FixaKardexDAL : DALModelo<FixaKardex>
    {
        public FixaKardexDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 1023;
            idExceptionSalvar[Operacao.Alterar] = 1024;
            idExceptionSalvar[Operacao.Excluir] = 1025;
        }
    }
}