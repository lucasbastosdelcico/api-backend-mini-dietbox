using MiniDietboxAPI.Domain.Abstractions.Interfaces;
using MiniDietboxAPI.Domain.Abstractions.IService;
using MiniDietboxAPI.Domain.Data.Entities;

namespace MiniDietboxAPI.Domain.Services
{
    public class FoodService : IFoodService 
    {
        private readonly IFoodRepository _foodRepository;

        public FoodService(IFoodRepository mealplansRepository)
        {
            _foodRepository = mealplansRepository;
        }

        public async Task<IEnumerable<Food>> GetAllAsync()
        {
            var result = await _foodRepository.GetAllAsync().ConfigureAwait(false);
            return result;
        }

        public async Task<Food> GetByIdAsync(int id)
        {
            var food = await _foodRepository.GetByIdAsync(id).ConfigureAwait(false);
            if (food == null)
                throw new Exception($"Food with ID {id} not found.");
            return food;
        }

        public async Task<Food> UpdateAsync(Food food)
        {
            await _foodRepository.UpdateAsync(food).ConfigureAwait(false);
            return food;
        }

        public async Task<Food> CreateAsync(Food food)
        {
            await _foodRepository.AddAsync(food).ConfigureAwait(false);
            return food;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var food = await _foodRepository.GetByIdAsync(id).ConfigureAwait(false);
            if (food == null)
            {
                throw new Exception($"Food with ID {id} not found.");
            }
            await _foodRepository.DeleteAsync(id).ConfigureAwait(false);
            return true;
        }
    }
}
