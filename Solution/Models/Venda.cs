namespace Models
{
    public class Venda : IEntidade
    {
        public int Id { get; set; }
        public Cliente? Cliente { get; set; }
        public float TotalDosProdutos { get; set; }
        public float ValorDesconto { get; set; }
        public float ValorAcrescimo { get; set; }
        public float ValorTotal { get; set; }
        public List<ItemVenda>? ItemVenda { get; set; }
    }
}