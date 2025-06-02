using Microsoft.EntityFrameworkCore;
using MiniDietboxAPI.Domain.Abstractions.Interfaces;
using MiniDietboxAPI.Domain.Data.Entities;
using MiniDietboxAPI.Domain.Data.Repository.Generics;

namespace MiniDietboxAPI.Domain.Data.Repository
{
    public class FoodRepository : Repository<Food>, IFoodRepository
    {
        public FoodRepository(AppDbContext.AppDbContext context) : base(context)
        {
        }
    }
}
