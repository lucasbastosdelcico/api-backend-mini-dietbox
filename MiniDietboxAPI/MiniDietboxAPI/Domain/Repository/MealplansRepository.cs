using Microsoft.EntityFrameworkCore;
using MiniDietboxAPI.Domain.Abstractions.Interfaces;
using MiniDietboxAPI.Domain.Entities;
using MiniDietboxAPI.Domain.Repository.Generics;

namespace MiniDietboxAPI.Domain.Repository
{
    public class MealplansRepository : Repository<Mealplan>, IMealplansRepository
    {
        public MealplansRepository(DbContext context) : base(context)
        {
        }
    }
}
