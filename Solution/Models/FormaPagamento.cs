using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class FormaPagamento : IEntidade
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        [Column(TypeName = "varchar(150)")]
        public string Descricao { get; set; }
    }
}