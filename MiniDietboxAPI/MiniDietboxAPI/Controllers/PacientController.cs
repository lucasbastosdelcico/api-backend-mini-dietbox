using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniDietboxAPI.Domain.Abstractions.IService;
using MiniDietboxAPI.Domain.Data.Entities;

namespace MiniDietboxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PacientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _patientService.GetAllAsync().ConfigureAwait(false);
            if (result == null)
            {
                return NotFound("No patients found.");
            }
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            var result = await _patientService.GetByIdAsync(id).ConfigureAwait(false);
            if (result == null)
            {
                return NotFound("patient not found.");
            }
            return Ok(result);
        }
        [HttpGet("/{id}/mealplans/today")]
        public async Task<IActionResult> GetMealansTodayAsync([FromRoute] int id ) 
        {
            var result = await _patientService.GetPatientsWithMealplansAsync(id).ConfigureAwait(false);
            if (result == null)
            {
                return NotFound("No meal plans found for today.");
            }
            return Ok(result);
        }

        [HttpPost("/create")]
        public async Task<IActionResult> PostAsync([FromBody] Patient patient )
        {
            var result = await _patientService.CreateAsync(patient).ConfigureAwait(false);
            if (result == null)
            {
                return BadRequest("Failed to create patient.");
            }
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePatientAsync([FromBody] Patient patient)
        {
            var result = await _patientService.UpdateAsync(patient).ConfigureAwait(false);

            if (result == null)
            {
                return NotFound("Patient not found.");
            }
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async  Task<IActionResult> Delete([FromRoute]int id)
        {
            var result = await  _patientService.DeleteAsync(id).ConfigureAwait(false);
            if (!result)
            {
                return NotFound("Patient not found.");
            }
            return Ok(result);
        }
    }
}
