using Models;

namespace DAL
{
    public class PermissaoDAL : DALModelo<Permissao>
    {
        public PermissaoDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 1050;
            idExceptionSalvar[Operacao.Alterar] = 1051;
            idExceptionSalvar[Operacao.Excluir] = 1052;
        }
    }
}