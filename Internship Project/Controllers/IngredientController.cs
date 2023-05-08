using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Database.Entities;
using NormativeCalculator.DTOs.IngredientDto;
using NormativeCalculator.DTOs.Response;
using NormativeCalculator.Service.IngredientService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Internship_Project.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;

        public IngredientController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetIngredientDto>>>> Get()
        {
            return Ok(await _ingredientService.GetAllIngredients());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetIngredientDto>>> GetOne(int id)
        {
            return Ok(await _ingredientService.GetOneIngredient(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetIngredientDto>>>> AddIngredient(AddIngredient newIngredient)
        {
            return Ok(await _ingredientService.AddIngredient(newIngredient));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetIngredientDto>>>> DeleteIngredient(int id)
        {
            var response = await _ingredientService.DeleteIngredient(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetIngredientDto>>> UpdateIngredient(UpdateIngredient updatedIngredient)
        {
            var response = await _ingredientService.UpdateIngredient(updatedIngredient);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
