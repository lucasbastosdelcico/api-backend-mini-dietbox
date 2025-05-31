namespace MiniDietboxAPI.Domain.Abstractions
{
    public interface IRepository<T>
    {
        Task<T>GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}
