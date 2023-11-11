using DAL;
using Models;

namespace BLL
{
    public class UsuarioBLL
    {
        private void ValidarDados(Usuario _usuario, string _confirmacaoSenha)
        {
            if (string.IsNullOrEmpty(_usuario.Nome))
                throw new Exception("Informe o campo nome.") { Data = { { "Id", 1 } } };
            if (string.IsNullOrEmpty(_usuario.NomeUsuario))
                throw new Exception("Informe o campo nome de usuário.") { Data = { { "Id", 2 } } };
            if (string.IsNullOrEmpty(_usuario.Senha))
                throw new Exception("Informe o campo nome de usuário.") { Data = { { "Id", 3 } } };
            if (_usuario.Senha.Length <= 5 || _usuario.Senha.Length > 20)
                throw new Exception("A senha deve ter entre 6 e 20 caracteres.") { Data = { { "Id", 4 } } };
            if (_confirmacaoSenha != _usuario.Senha)
                throw new Exception("A senha e a confirmação de senha não são iguais.") { Data = { { "Id", 5 } } };
            if (_usuario.Senha == Constantes.SenhaParaExibicao)
                throw new Exception("A senha informada não é uma senha segura.") { Data = { { "Id", 6 } } };
        }
        public void Inserir(Usuario _usuario, string _confirmacaoSenha)
        {
            ValidarDados(_usuario, _confirmacaoSenha);
            new UsuarioDAL().Inserir(_usuario);
        }
        public void Altetar(Usuario _usuario, string _confirmacaoSenha)
        {
            ValidarDados(_usuario, _confirmacaoSenha);
            new UsuarioDAL().Alterar(_usuario);
        }
        public void Excluir(int _id)
        {
            new UsuarioDAL().Excluir(_id);
        }
        public List<Usuario> BuscarTodos()
        {
            return new UsuarioDAL().BuscarTodos();
        }
        public Usuario BuscarPorId(int _id)
        {
            return new UsuarioDAL().BuscarPorId(_id);
        }
        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            return new UsuarioDAL().BuscarPorNomeUsuario(_nomeUsuario);
        }

        public List<Usuario> BuscarPorNome(string _nome)
        {
            return new UsuarioDAL().BuscarPorNome(_nome);
        }

        public void Salvar(Usuario _usuario, string _confirmacaoSenha)
        {
            if (_usuario.Id == 0)
                Inserir(_usuario, _confirmacaoSenha);
            else
                Altetar(_usuario, _confirmacaoSenha);
        }
    }
}
