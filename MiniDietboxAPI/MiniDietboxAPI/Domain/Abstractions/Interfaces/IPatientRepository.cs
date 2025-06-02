using MiniDietboxAPI.Domain.Data.Entities;
using MiniDietboxAPI.Domain.Data.Results;

namespace MiniDietboxAPI.Domain.Abstractions.Interfaces
{
    public interface IPatientRepository : IRepository<Patient>
    {
        Task<IEnumerable<MealplanTodayResult>> GetPatientsWithMealplansAsync(int id);
    }
}
