using MiniDietboxAPI.Domain.Data.Entities;
using MiniDietboxAPI.Domain.Data.Results.DTO;

namespace MiniDietboxAPI.Domain.Abstractions.IService
{
    public interface IMealplanService
    {
        Task<IEnumerable<Mealplan>> GetAllAsync();
        Task<Mealplan> GetByIdAsync(int id);
        Task<Mealplan> UpdateAsync(CreateMealplanDto dto);
        Task<Mealplan> CreateAsync(CreateMealplanDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
