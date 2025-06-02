namespace MiniDietboxAPI.Domain.Data.Entities.Generics
{
    public interface IBaseEntity
    {
        bool IsActive { get; set; }
        bool IsDeleted { get; set; }
    }
}
