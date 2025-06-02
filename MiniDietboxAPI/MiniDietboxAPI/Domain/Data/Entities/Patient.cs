using MiniDietboxAPI.Domain.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniDietboxAPI.Domain.Data.Entities
{
    [Table("Patients")]
    public class Patient : Generics.Generics
    {
        [Required]
        [StringLength(50)]
        public string? Nome { get; set; }
        [Required]
        [StringLength(14)]
        public string? Cpf { get; set; }
        [Required]
        public Sexo Sexo { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
    }
}
