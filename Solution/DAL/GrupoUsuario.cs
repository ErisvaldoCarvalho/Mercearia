using Models;

namespace DAL
{
    public class GrupoUsuarioDAL : DALModelo<GrupoUsuario>
    {
        public GrupoUsuarioDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 1035;
            idExceptionSalvar[Operacao.Alterar] = 1036;
            idExceptionSalvar[Operacao.Excluir] = 1037;
        }

        
    }
}