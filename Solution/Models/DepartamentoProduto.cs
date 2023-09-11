using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class DepartamentoProduto : IEntidade
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        [Column(TypeName = "varchar(150)")]
        public string Descricao { get; set; }
    }
}