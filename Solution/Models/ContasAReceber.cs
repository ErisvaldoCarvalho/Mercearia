namespace Models
{
    public class ContasAReceber : IEntidade
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public float Valor { get; set; }
        public float ValorRecebido { get; set; }
        public float ValorAReceber { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public List<ItemContasAReceber> ItemContasAReceberList { get; set; }
    }
}
