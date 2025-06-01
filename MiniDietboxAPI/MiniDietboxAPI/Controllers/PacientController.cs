using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniDietboxAPI.Domain.Abstractions.IService;

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
        public Task<IActionResult> Get()
        {
            return Task.FromResult<IActionResult>(Ok("Pacient endpoint is working!"));
        }
        [HttpGet]
        public Task<IActionResult> GetById()
        {
            return Task.FromResult<IActionResult>(Ok("Pacient endpoint is working!"));
        }
        [HttpPost]
        public Task<IActionResult> Post()
        {
            return Task.FromResult<IActionResult>(Ok("Pacient endpoint is working!"));
        }
        [HttpPut]
        public Task<IActionResult> Put()
        {
            return Task.FromResult<IActionResult>(Ok("Pacient endpoint is working!"));
        }
        [HttpDelete]
        public Task<IActionResult> Delete()
        {
            return Task.FromResult<IActionResult>(Ok("Pacient endpoint is working!"));
        }
    }
}
