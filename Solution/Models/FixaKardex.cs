namespace Models
{
    public class FixaKardex : IEntidade
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public Venda Venda { get; set; }
        public Compra Compra { get; set; }
        public double Quantidade { get; set; }
        public double EstoqueAnterior { get; set; }
        public double EstoqueAtual { get; set; }
    }
}
