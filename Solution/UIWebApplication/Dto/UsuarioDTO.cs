using Models;

namespace UIWebApplication.Dto
{
    public class UsuarioDTO
    {
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public bool Ativo { get; set; }
        public string? NomeUsuario { get; set; }
        public string ConfirmacaoSenha { get; set; }
    }
}
