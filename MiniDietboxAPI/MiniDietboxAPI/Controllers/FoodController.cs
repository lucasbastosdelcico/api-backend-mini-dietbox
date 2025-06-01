using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniDietboxAPI.Domain.Abstractions.IService;

namespace MiniDietboxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService _foodService;
        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }
        [HttpGet]
        public Task<IActionResult> Get()
        {
            return Task.FromResult<IActionResult>(Ok("Pacient endpoint is working!"));
        }
        [HttpGet("{id}")]
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
