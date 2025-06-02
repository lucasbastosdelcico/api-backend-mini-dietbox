using MiniDietboxAPI.Domain.Data.Entities;

namespace MiniDietboxAPI.Domain.Abstractions.IService
{
    public interface IFoodService
    {
        Task<IEnumerable<Food>> GetAllAsync();
        Task<Food> GetByIdAsync(int id);
        Task<Food> UpdateAsync(Food food);
        Task<Food> CreateAsync(Food food);
        Task<bool> DeleteAsync(int id);
    }
}
