using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServicoDeLocacao_API.Models
{
    [Table("Locação do Carro")]
    public class RentalCar
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("Data Inicial")]
        public DateTime Começo { get; set; }

        [Required]
        [Column("Data Final")]
        public DateTime Final { get; set; }

        [Required]
        [Column("Veículo")]
        [StringLength(50)]
        public string Veiculo { get; set; }

        
    }
}
