using AutoMapper;
using NormativeCalculator.Database.Entities;
using NormativeCalculator.DTOs.IngredientDto;
using NormativeCalculator.DTOs.Models;
using NormativeCalculator.DTOs.Request;

namespace Internship_Project.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Recipe, AddRecipeRequest>().ReverseMap();
            CreateMap<Category, GetCategoryDto>();
            CreateMap<Recipe, RecipeDto>().ReverseMap();
            CreateMap<Recipe, RecipesDto>().ReverseMap();
            CreateMap<Recipe, Recipe_Dto>().ReverseMap();
            CreateMap<Recipe, GetRecipesDto>().ReverseMap();
            CreateMap<GetRecipesDto, RecipeDto>().ReverseMap();
            CreateMap<Category, AddCategoryRequest>().ReverseMap();
            CreateMap<AddIngredient, Ingredient>();
            CreateMap<Ingredient, GetIngredientDto>();
            CreateMap<RecipeIngredients, AddRecipeIngredient>().ReverseMap();
        }
    }
}
