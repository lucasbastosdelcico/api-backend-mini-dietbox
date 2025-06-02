using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniDietboxAPI.Domain.Abstractions.IService;
using MiniDietboxAPI.Domain.Data.Entities;

namespace MiniDietboxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService _foodService;
        public  FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _foodService.GetAllAsync();
            if (result == null)
                return NotFound("No food items found.");

            return Ok(result);
            
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute]int id )
        {
            var result = await _foodService.GetByIdAsync(id);

            if (result == null)
                return NotFound($"Food with ID {id} not found.");
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] Food food)
        {
           var result = await _foodService.CreateAsync(food);
            if (result == null)
                return BadRequest("Failed to create food item.");
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> PutAsync([FromBody] Food food  )
        {
           var result = await _foodService.UpdateAsync(food); 
            if (result == null)
                return NotFound("Food item not found for update.");
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
           var result = await _foodService.DeleteAsync(id);
            if (!result)
                return NotFound($"Food with ID {id} not found for deletion.");
            return NoContent();
        }
    }
}
