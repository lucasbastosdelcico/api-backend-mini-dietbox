using MiniDietboxAPI.Domain.Abstractions.Interfaces;
using MiniDietboxAPI.Domain.Abstractions.IService;
using MiniDietboxAPI.Domain.Data.Entities;
using MiniDietboxAPI.Domain.Data.Repository;
using MiniDietboxAPI.Domain.Data.Results.DTO;
using System.Collections;

namespace MiniDietboxAPI.Domain.Services
{
    public class MealplanService : IMealplanService
    {
        private readonly IMealplansRepository _mealplansRepository;
        private readonly IFoodRepository _foodRepository;
        private readonly IPatientRepository _patientRepository;
        public MealplanService
            (
            IMealplansRepository mealplansRepository,
            IFoodRepository foodRepository,
            IPatientRepository patientRepository
            )
        {
            _mealplansRepository = mealplansRepository;
            _foodRepository = foodRepository;
            _patientRepository = patientRepository;
        }

        public async Task<IEnumerable<Mealplan>> GetAllAsync()
        {
            return await _mealplansRepository.GetAllAsync();
        }
        public async Task<Mealplan> GetByIdAsync(int id)
        {
            var result = await _mealplansRepository.GetByIdAsync(id).ConfigureAwait(false);
            if (result == null)
                throw new Exception($"Mealplan with ID {id} not found.");
            return result;
        }

        public async Task<Mealplan> UpdateAsync(CreateMealplanDto dto)
        {

            var mealplan = await _mealplansRepository.GetByIdAsync(dto.Id);
            if (mealplan == null)
                throw new Exception("Not Found");

            var food = await _foodRepository.GetByIdAsync(dto.FoodId);
            if (food == null)
                throw new Exception("Not Found");

            var patient = await _patientRepository.GetByIdAsync(dto.PatientId);
            if (patient == null)
                throw new Exception("Not Found");

            mealplan.FoodId = dto.FoodId;
            mealplan.PatientId = dto.PatientId;
            mealplan.Nome = dto.Nome;
            mealplan.DataPlanoAlimentar = dto.DataPlanoAlimentar;
            mealplan.Food = food;
            mealplan.Patient = patient;

            await _mealplansRepository.UpdateAsync(mealplan);

            return mealplan;
        }

        public async Task<Mealplan> CreateAsync(CreateMealplanDto dto)
        {
            var food = await _foodRepository.GetByIdAsync(dto.FoodId);
            if (food == null)
                throw new Exception("Not Found");

            var patient = await _patientRepository.GetByIdAsync(dto.PatientId);
            if (patient == null)
                throw new Exception("Not Found");


            var mealplan = new Mealplan
            {
                FoodId = dto.FoodId,
                PatientId = dto.PatientId,
                Nome = dto.Nome,
                DataPlanoAlimentar = dto.DataPlanoAlimentar,
                Food = food,
                Patient = patient
            };

            await _mealplansRepository.AddAsync(mealplan).ConfigureAwait(false);


            return mealplan;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var mealplan = await _mealplansRepository.GetByIdAsync(id).ConfigureAwait(false);
            if (mealplan == null)
            {
                throw new Exception($"Mealplan with ID {id} not found.");
            }
            await _mealplansRepository.DeleteAsync(id).ConfigureAwait(false);
            return true;
        }

    }
}
