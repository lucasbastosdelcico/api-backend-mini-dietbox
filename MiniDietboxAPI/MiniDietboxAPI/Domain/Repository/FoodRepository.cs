using MiniDietboxAPI.Domain.Abstractions;
using MiniDietboxAPI.Domain.Entities;

namespace MiniDietboxAPI.Domain.Repository
{
    public class FoodRepository : Repository<Food> ,IFoodRepository
    {
    }
}
