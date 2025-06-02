using System.ComponentModel.DataAnnotations;

namespace MiniDietboxAPI.Domain.Data.Results.DTO
{
    public class CreateMealplanDto
    {
        public int Id { get; set; }
        [Required]
        public int FoodId { get; set; }
        [Required]
        public int PatientId { get; set; }
        public string Nome { get; set; } = null!;
        public DateTime DataPlanoAlimentar { get; set; } = DateTime.Now;
    }

}
