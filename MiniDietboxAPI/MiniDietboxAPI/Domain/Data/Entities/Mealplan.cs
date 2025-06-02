using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniDietboxAPI.Domain.Data.Entities
{
    [Table("Mealplans")]
    public class Mealplan : Generics.Generics
    {
        [Required]
        public int FoodId { get; set; }

        [ForeignKey("FoodId")]
        public Food Food { get; set; } = null!;

        [Required]
        public int PatientId { get; set; }

        [ForeignKey("PatientId")]
        public Patient Patient { get; set; } = null!;

        [Required]
        public string Nome { get; set; } = null!;

        [Required]
        public DateTime DataPlanoAlimentar { get; set; } = DateTime.Now;
    }
}
