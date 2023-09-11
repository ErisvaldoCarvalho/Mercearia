namespace Models
{
    public class Produto : IEntidade
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }
        public float Estoque { get; set; }
        public Marca Marca { get; set; }
        public CategoriaProduto CategoriaProduto { get; set; }
        public SubGrupoProduto SubGrupoProduto { get; set; }
    }
}