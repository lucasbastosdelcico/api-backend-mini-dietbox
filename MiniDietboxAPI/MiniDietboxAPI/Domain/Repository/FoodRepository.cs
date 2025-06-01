using Microsoft.EntityFrameworkCore;
using MiniDietboxAPI.Domain.Abstractions.Interfaces;
using MiniDietboxAPI.Domain.Entities;
using MiniDietboxAPI.Domain.Repository.Generics;

namespace MiniDietboxAPI.Domain.Repository
{
    public class FoodRepository : Repository<Food> ,IFoodRepository
    {
        public FoodRepository(DbContext context) : base(context)
        {
        }
    }
}
