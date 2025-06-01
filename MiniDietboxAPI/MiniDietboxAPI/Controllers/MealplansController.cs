using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniDietboxAPI.Domain.Abstractions.IService;

namespace MiniDietboxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealplansController : ControllerBase
    {
        private readonly IMealplanService _mealplanService;

        public MealplansController(IMealplanService mealplanService)
        {
            _mealplanService = mealplanService;
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
