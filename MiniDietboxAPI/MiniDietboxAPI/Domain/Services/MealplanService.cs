using MiniDietboxAPI.Domain.Abstractions.Interfaces;
using MiniDietboxAPI.Domain.Abstractions.IService;

namespace MiniDietboxAPI.Domain.Services
{
    public class MealplanService : IMealplanService
    {
        private readonly IMealplansRepository _mealplansRepository;
        public MealplanService(IMealplansRepository mealplansRepository)
        {
            _mealplansRepository = mealplansRepository;
        }
    }
}
