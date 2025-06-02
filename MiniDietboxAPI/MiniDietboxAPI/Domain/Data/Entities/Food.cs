using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniDietboxAPI.Domain.Data.Entities
{
    [Table("Food")]
    public class Food : Generics.Generics
    {
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        [Required]
        public float Gramas { get; set; }
        [Required]
        public float Calorias { get; set; }

    }
}
