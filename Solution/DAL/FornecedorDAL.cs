using Models;

namespace DAL
{
    public class FornecedorDAL : DALModelo<Fornecedor>
    {
        public FornecedorDAL()
        {
            idExceptionSalvar[Operacao.Inserir] = 1029;
            idExceptionSalvar[Operacao.Alterar] = 1030;
            idExceptionSalvar[Operacao.Excluir] = 1031;
        }
    }
}