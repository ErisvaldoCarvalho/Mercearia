using System.Security;

namespace Models
{
    public class GrupoUsuario : IEntidade
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public List<Permissao>? PermissaoListMyProperty { get; set; }
        public List<Usuario>? UsuarioList { get; set; }
    }
}