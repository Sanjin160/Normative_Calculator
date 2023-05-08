using NormativeCalculator.Database.Entities;
using NormativeCalculator.DTOs.Models;
using NormativeCalculator.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Service.Interface
{
    public interface IRecipeService
    {
        Task<GetRecipesDto> GetRecipeByIdAsync(int id);
        Task<PaginationModel<List<RecipeDto>>> GetRecipeAsync(RecipeSearchRequest request);
        Task<Recipe_Dto> DeleteRecipeAsync(int id);
        Task<RecipesDto> InsertRecipeAsync(AddRecipeRequest request);
        Task<RecipesDto> UpdateRecipeAsync(int id, AddRecipeRequest request);
    }
}
