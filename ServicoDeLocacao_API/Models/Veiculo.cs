using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServicoDeLocacao_API.Models
{
    public class Veiculo
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [Column("Modelo do Véiculo)")]
        [StringLength(50)]
        public string Modelo { get; set; }
    }
}
