using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class GrupoProduto:IEntidade
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        [Column(TypeName = "varchar(150)")]
        public string Descricao { get; set; }
        public DepartamentoProduto DepartamentoProduto { get; set; }
    }
}