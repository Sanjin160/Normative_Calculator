using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Database.Entities;
using NormativeCalculator.DTOs.Request;
using NormativeCalculator.Service.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Internship_Project.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeService _recipeService;
        public RecipesController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetRecipesAsync([FromQuery] RecipeSearchRequest request)
        {
            return Ok(await _recipeService.GetRecipeAsync(request));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRecipeByIdAsync(int id)
        {
            return Ok(await _recipeService.GetRecipeByIdAsync(id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecipeAsync(int id)
        {
            return Ok(await _recipeService.DeleteRecipeAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> InsertRecipeAsync(AddRecipeRequest request)
        {
            return Ok(await _recipeService.InsertRecipeAsync(request));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRecipeAsync(int id, AddRecipeRequest request)
        {
            return Ok(await _recipeService.UpdateRecipeAsync(id, request));
        }
    }
}
