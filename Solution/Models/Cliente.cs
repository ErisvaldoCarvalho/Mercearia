using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Cliente : IEntidade
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        [Column(TypeName = "varchar(150)")]
        public string? Nome { get; set; }
        [Required]
        [MaxLength(15)]
        [Column(TypeName = "varchar(15)")]
        public string Fone { get; set; }
    }
}