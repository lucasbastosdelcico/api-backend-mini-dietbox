using MiniDietboxAPI.Domain.Data.Entities;
using MiniDietboxAPI.Domain.Data.Results;

namespace MiniDietboxAPI.Domain.Abstractions.IService
{
    public interface IPatientService
    {
        Task<IEnumerable<Patient>> GetAllAsync();
        Task<Patient> GetByIdAsync(int id);
        Task<Patient> UpdateAsync(Patient patient);
        Task<Patient> CreateAsync(Patient patient);
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<MealplanTodayResult>> GetPatientsWithMealplansAsync(int id);
    }
}
