using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniDietboxAPI.Domain.Abstractions.IService;
using MiniDietboxAPI.Domain.Data.Entities;
using MiniDietboxAPI.Domain.Data.Results.DTO;
using System.Reflection.Metadata.Ecma335;

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
        public async  Task<IActionResult> GetAllAsync()
        {
            var result = await _mealplanService.GetAllAsync().ConfigureAwait(false);
            if (result == null)
            {
                return NotFound("No meal plans found.");
            }
            return(Ok(result));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            var result = await _mealplanService.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound($"Meal plan with ID {id} not found.");
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] CreateMealplanDto mealplan)
        {
            var result = await _mealplanService.CreateAsync(mealplan).ConfigureAwait(false);
            if (result == null)
            {
                return BadRequest("Failed to create meal plan.");
            }
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> PutAsync([FromBody] CreateMealplanDto mealplan)
        {
            var result = await _mealplanService.UpdateAsync(mealplan).ConfigureAwait(false);
            if (result == null)
            {
                return NotFound($"Meal plan with ID {mealplan.Id} not found.");
            }
            return Ok(result);

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
           var result = await _mealplanService.DeleteAsync(id).ConfigureAwait(false);
            if (!result)
            {
                return NotFound($"Meal plan with ID {id} not found.");
            }
            return Ok();
        }
    }
}
