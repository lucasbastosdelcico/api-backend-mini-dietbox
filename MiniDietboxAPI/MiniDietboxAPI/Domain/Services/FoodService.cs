using MiniDietboxAPI.Domain.Abstractions.Interfaces;
using MiniDietboxAPI.Domain.Abstractions.IService;

namespace MiniDietboxAPI.Domain.Services
{
    public class FoodService : IFoodService 
    {
        private readonly IFoodRepository _mealplansRepository;

        public FoodService(IFoodRepository mealplansRepository)
        {
            _mealplansRepository = mealplansRepository;
        }

    }
}
