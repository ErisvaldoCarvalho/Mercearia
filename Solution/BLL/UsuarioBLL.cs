using DAL;
using Models;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario, string _confirmacaoSenha)
        {
            ValidarDados(_usuario, _confirmacaoSenha);

            using (DataContext dataContext = new DataContext())
            {
                dataContext.Add(_usuario);
                dataContext.SaveChanges();
            }
        }

        private void ValidarDados(Usuario _usuario, string _confirmacaoSenha)
        {
            //TODO: Validar senha

            if (String.IsNullOrEmpty(_usuario.Nome))
                throw new Exception("Informe o campo nome") { Data = { { "Id", 1 } } };

            if (String.IsNullOrEmpty(_usuario.NomeUsuario))
                throw new Exception("Informe o campo nome de usuário") { Data = { { "Id", 2 } } };

            if (String.IsNullOrEmpty(_usuario.Senha))
                throw new Exception("Informe o campo senha") { Data = { { "Id", 4 } } };

            if (_usuario.Senha.Length < 6)
                throw new Exception("A senha deve ter pelo menos 6 caracteres") { Data = { { "Id", 4 } } };
        }

        public void Alterar(Usuario _usuario, string _confirmacaoSenha)
        {
            ValidarDados(_usuario, _confirmacaoSenha);

            using (DataContext dataContext = new DataContext())
            {
                dataContext.Update(_usuario);
                dataContext.SaveChanges();
            }
        }
        public void Excluir(int _id)
        {
            var usuario = BuscarPorId(_id);
            using (DataContext dataContext = new DataContext())
            {
                dataContext.Usuario.Remove(usuario);
                dataContext.SaveChanges();
            }
        }

        public Usuario BuscarPorId(int _id)
        {
            var r = new DataContext().Usuario.Where(x => x.Id == _id).Single();
            return r;
        }
        public List<Usuario> BuscarTodos()
        {
            return new DataContext().Usuario.ToList();
        }
        public List<Usuario> BuscarPorNome(string text)
        {
            return new DataContext().Usuario.Where(usuario => usuario.Nome.Contains(text)).ToList();
        }
        public List<Usuario> BuscarPorNomeUsuario(string _nomeUsuario)
        {
            return new DataContext().Usuario.Where(usuario => usuario.NomeUsuario == _nomeUsuario).ToList();
        }
        public bool Altenicar(string _nomeUsuario, string _senha)
        {
            if (string.IsNullOrEmpty(_nomeUsuario) || string.IsNullOrEmpty(_senha))
                throw new Exception("Você precisa informar o nome de usuário e a senha!") { Data = { { "Id", 1001 } } };

            Usuario usuario = new DataContext().Usuario.Where(usuario => usuario.NomeUsuario == _nomeUsuario).SingleOrDefault();
            if (usuario == null || usuario.Senha != _senha || !usuario.Ativo)
                throw new Exception("Usuário ou senha inválida!") { Data = { { "Id", 1002 } } };

            Models.Constantes.UsuarioLogado = usuario;
            return true;
        }

        public bool ExisteUsuarioNoBanco()
        {
            var retorno = new DataContext().Usuario.FirstOrDefault();
            return retorno != null;
        }
    }
}
