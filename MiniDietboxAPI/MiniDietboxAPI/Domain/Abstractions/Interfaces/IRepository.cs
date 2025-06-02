namespace MiniDietboxAPI.Domain.Abstractions.Interfaces
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
        Task<T?> AddAsync(T entity);
        Task<T?> UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
