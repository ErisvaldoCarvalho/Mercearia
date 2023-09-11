namespace Models
{
    public class Compra : IEntidade
    {
        public int Id { get; set; }
        public Fornecedor? Fornecedor { get; set; }
        public float TotalDosProdutos { get; set; }
        public float ValorDesconto { get; set; }
        public float ValorAcrescimo { get; set; }
        public float ValorFrete { get; set; }
        public float ValorTotal { get; set; }
        public List<ItemCompra>? ItemCompra { get; set; }
    }
}