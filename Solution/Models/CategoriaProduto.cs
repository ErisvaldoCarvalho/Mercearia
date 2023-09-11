using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class CategoriaProduto : IEntidade
    {
        public int Id { get; set; }
        [MaxLength(150)]
        [Column(TypeName = "varchar(150)")]
        public string Descricao { get; set; }
    }
}