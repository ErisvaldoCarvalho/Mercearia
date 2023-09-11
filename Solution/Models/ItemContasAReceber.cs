namespace Models
{
    public class ItemContasAReceber : IEntidade
    {
        public int Id { get; set; }
        public ContasAReceber ContasAReceber { get; set; }
        public DateTime DataPagamento { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public Usuario Usuario { get; set; }
    }
}