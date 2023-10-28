using Models;

namespace DAL
{
    public class MarcaDAL : DALModelo<Marca>
    {
        public MarcaDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 1047;
            idExceptionSalvar[Operacao.Alterar] = 1048;
            idExceptionSalvar[Operacao.Excluir] = 1049;
        }
    }
}