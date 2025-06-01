using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MiniDietboxAPI.Domain.Entities.Generics;

namespace MiniDietboxAPI.Domain.Entities
{
    [Table("Mealplans")]
    public class Mealplan : Generics.Generics
    {
        [ForeignKey("FoodId")]
        public Food Food { get; set; } = null!;

        [ForeignKey("PatientId")]
        public Patient Patient { get; set; } = null!;

        [Required]
        public string? Nome { get; set; }
        [Required]
        public DateTime DataPlanoAlimentar { get; set; }
    }
}
