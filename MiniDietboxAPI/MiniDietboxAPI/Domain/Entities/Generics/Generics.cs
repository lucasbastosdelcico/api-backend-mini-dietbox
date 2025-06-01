namespace MiniDietboxAPI.Domain.Entities.Generics
{
    public class Generics
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
