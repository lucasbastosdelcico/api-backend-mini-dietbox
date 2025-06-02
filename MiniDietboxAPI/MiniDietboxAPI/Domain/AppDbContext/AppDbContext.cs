using Microsoft.EntityFrameworkCore;
using MiniDietboxAPI.Domain.Data.Entities;

namespace MiniDietboxAPI.Domain.AppDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Patient>? Patients { get; set; }
        public DbSet<Food>? Foods { get; set; }
        public DbSet<Mealplan>? Mealplans { get; set; }


    }
}
