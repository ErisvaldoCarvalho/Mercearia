namespace Models
{
    public class ItemCompra : IEntidade
    {
        public int Id { get; set; }
        public Compra? Compra { get; set; }
        public float Quantidade { get; set; }
        public float ValorDesconto { get; set; }
        public float ValorAcrescimo { get; set; }
        public float ValorFrete { get; set; }
        public float ValorTotal { get; set; }
        public Produto? Produto { get; set; }
    }
}