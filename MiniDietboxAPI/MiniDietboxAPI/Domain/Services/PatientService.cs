using MiniDietboxAPI.Domain.Abstractions.Interfaces;
using MiniDietboxAPI.Domain.Abstractions.IService;

namespace MiniDietboxAPI.Domain.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientsRepository;
        public PatientService(IPatientRepository pacientsRepository)
        {
            _patientsRepository = pacientsRepository;
        }
       
    }
}
