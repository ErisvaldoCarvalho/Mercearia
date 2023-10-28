namespace Models
{
    public class ContasAPagar : IEntidade
    {
        public int Id { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public float Valor { get; set; }
        public float ValorPago { get; set; }
        public float ValorAPagar { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public List<ItemContasAReceber> ItemContasAPagarList { get; set; }
    }
}