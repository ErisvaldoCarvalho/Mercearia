namespace Models
{
    public class Usuario : IEntidade
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public bool Ativo { get; set; }
        public string? NomeUsuario { get; set; }
        public List<GrupoUsuario>? GrupoUsuarioList { get; set; }
    }
}
