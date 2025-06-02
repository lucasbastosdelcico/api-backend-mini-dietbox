using Microsoft.EntityFrameworkCore;
using MiniDietboxAPI.Domain.Abstractions.Interfaces;
using MiniDietboxAPI.Domain.Data.Entities;
using MiniDietboxAPI.Domain.AppDbContext;
using MiniDietboxAPI.Domain.Data.Results;
using MiniDietboxAPI.Domain.Data.Repository.Generics;


namespace MiniDietboxAPI.Domain.Data.Repository
{
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
        private readonly AppDbContext.AppDbContext _context;
        public PatientRepository(AppDbContext.AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MealplanTodayResult>> GetPatientsWithMealplansAsync(int id)
        {
            var date = DateTime.Today;
            var patients = await (from patient in _context.Patients
                                  join mealplan in _context.Mealplans
                                  on patient.Id equals mealplan.Patient.Id
                                  where
                                  mealplan.DataPlanoAlimentar >= date
                                  && patient.Id == id
                                  && patient.IsActive
                                  && !patient.IsDeleted
                                  select new MealplanTodayResult
                                  {
                                      IdMealplan = mealplan.Id,
                                      NameMealplan = mealplan.Nome,
                                      PatientName = patient.Nome
                                  })
                            .AsNoTracking()
                            .ToListAsync();

            return patients;
        }
    }
}
