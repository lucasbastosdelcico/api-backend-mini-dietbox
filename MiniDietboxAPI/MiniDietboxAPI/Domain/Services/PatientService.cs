using MiniDietboxAPI.Controllers;
using MiniDietboxAPI.Domain.Abstractions.Interfaces;
using MiniDietboxAPI.Domain.Abstractions.IService;
using MiniDietboxAPI.Domain.Data.Entities;
using MiniDietboxAPI.Domain.Data.Results;

namespace MiniDietboxAPI.Domain.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientsRepository;

        public PatientService(IPatientRepository pacientsRepository)
        {
            _patientsRepository = pacientsRepository;
        }

        public async Task<IEnumerable<Patient>> GetAllAsync()
        {
            var result = await _patientsRepository.GetAllAsync().ConfigureAwait(false);

            return result;
        }

        public async Task<Patient> GetByIdAsync(int id)
        {
            var patient = await _patientsRepository.GetByIdAsync(id).ConfigureAwait(false);
            if (patient == null)
                throw new Exception($"Patient with ID {id} not found.");
            return patient;
        }

        public async Task<Patient> UpdateAsync(Patient patient )
        {
            await _patientsRepository.UpdateAsync(patient).ConfigureAwait(false);
            return patient;
        }

        public async Task<Patient> CreateAsync(Patient patient)
        {
            await _patientsRepository.AddAsync(patient).ConfigureAwait(false);
            return patient;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var patient = await _patientsRepository.GetByIdAsync(id).ConfigureAwait(false);
            if (patient == null)
            {
                throw new Exception($"Patient with ID {id} not found.");
            }
            await _patientsRepository.DeleteAsync(id).ConfigureAwait(false);
            return true;
        }

        public async Task<IEnumerable<MealplanTodayResult>> GetPatientsWithMealplansAsync(int id)
        {
            var result = await _patientsRepository.GetPatientsWithMealplansAsync(id).ConfigureAwait(false);
            return result;
        }

    }
}
