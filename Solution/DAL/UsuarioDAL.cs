using Models;

namespace DAL
{
    public class UsuarioDAL : DALModelo<Usuario>
    {
        public UsuarioDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 1057;
            idExceptionSalvar[Operacao.Alterar] = 1058;
            idExceptionSalvar[Operacao.Excluir] = 1059;
        }
        public override void PopularEntidadesRelacionadas(Usuario _usuario)
        {
            _usuario.GrupoUsuarioList = new GrupoUsuarioDAL().BuscarPorFK(_usuario);
        }
    }
}