using Microsoft.EntityFrameworkCore;
using MiniDietboxAPI.Domain.Abstractions.Interfaces;
using MiniDietboxAPI.Domain.Data.Entities;
using MiniDietboxAPI.Domain.Data.Repository.Generics;

namespace MiniDietboxAPI.Domain.Data.Repository
{
    public class MealplansRepository : Repository<Mealplan>, IMealplansRepository
    {
        private readonly AppDbContext.AppDbContext _context;
        public MealplansRepository(AppDbContext.AppDbContext context) : base(context)
        {
            _context = context;
        }


    }
}
