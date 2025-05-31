using Microsoft.EntityFrameworkCore;
using MiniDietboxAPI.Domain.Entities;

namespace MiniDietboxAPI.Domain.AppDbContext
{
    public class AppDbConext : DbContext
    {
        public AppDbConext(DbContextOptions<AppDbConext> options) : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Mealplan> Mealplans { get; set; }
    }
}
