using MiniDietboxAPI.Domain.Abstractions;
using MiniDietboxAPI.Domain.Entities;

namespace MiniDietboxAPI.Domain.Repository
{
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
    }
}
