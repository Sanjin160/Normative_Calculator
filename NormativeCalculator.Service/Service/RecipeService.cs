using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Database.EF;
using NormativeCalculator.Database.Entities;
using NormativeCalculator.DTOs.Models;
using NormativeCalculator.DTOs.Request;
using NormativeCalculator.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Service.Service
{
    public class RecipeService : IRecipeService
    {
        private readonly NormativeCalculatorDbContext _context;
        private readonly IRecipeIngredientPriceService _recipeIngredientPriceService;
        private readonly IMapper _mapper;
        public RecipeService(NormativeCalculatorDbContext context, IMapper mapper, IRecipeIngredientPriceService recipeIngredientPriceService)
        {
            _context = context;
            _mapper = mapper;
            _recipeIngredientPriceService = recipeIngredientPriceService;
        }
        public async Task<PaginationModel<List<RecipeDto>>> GetRecipeAsync(RecipeSearchRequest request)
        {
            var list = await _context.Recipe.Where(i=>i.IsDeleted== false).Include(i => i.RecipeIngredients).ThenInclude(
                i => i.Ingredient).Where(i => i.CategoryId == request.CategoryId).Where(
                r => string.IsNullOrWhiteSpace(request.SearchText) || r.Name.ToLower().StartsWith(
                    request.SearchText.ToLower().Trim()) || r.Description.ToLower().StartsWith(
                        request.SearchText.ToLower().Trim()) || r.RecipeIngredients.Any(i => i.Ingredient.Name
                        .ToLower().Contains(request.SearchText))).Select(s => new GetRecipesDto
                        {
                            Id = s.Id,
                            Name = s.Name,
                            TotalCost = _recipeIngredientPriceService.RecipePrice(s)
                        }).ToListAsync();
            list = list.OrderBy(i => i.TotalCost).Skip(request.Skip).Take(10).ToList();

            var count = _context.Recipe.Count();
            var data = _mapper.Map<List<RecipeDto>>(list);

            return new PaginationModel<List<RecipeDto>>(data, count);
        }
        public async Task<RecipesDto> InsertRecipeAsync(AddRecipeRequest request)
        {
            var entity = _mapper.Map<Recipe>(request);
            entity.DateCreated = DateTime.Now;
            entity.IsDeleted = false;

            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();

            if (request.Ingredients != null)
            {
                foreach (var ingredient in request.Ingredients)
                {
                    await _context.RecipeIngredients.AddAsync(new RecipeIngredients()
                    {
                        RecipeId = entity.Id,
                        IngredientId = ingredient.IngredientId,
                        MeasureType = ingredient.MeasureType,
                        Quantity = ingredient.Quantity
                    });
                }
            }

            await _context.SaveChangesAsync();

            return _mapper.Map<RecipesDto>(entity);
        }
        public async Task<Recipe_Dto> DeleteRecipeAsync(int Id)
        {
            var entity = await _context.Recipe.FirstOrDefaultAsync(i => i.Id == Id);
            entity.IsDeleted = true;

            await _context.SaveChangesAsync();

            return _mapper.Map<Recipe_Dto>(entity);
        }
        public async Task<RecipesDto> UpdateRecipeAsync(int id, AddRecipeRequest request)
        {
            var entity = await _context.Recipe.Include(i => i.RecipeIngredients).ThenInclude(i=>i.Ingredient).FirstOrDefaultAsync(i => i.Id == id);

            _mapper.Map(request, entity);

            if (request.Ingredients != null)
            {
                foreach (var ingredient in request.Ingredients)
                {
                    await _context.RecipeIngredients.AddAsync(new RecipeIngredients()
                    {
                        RecipeId = entity.Id,
                        IngredientId = ingredient.IngredientId,
                        MeasureType = ingredient.MeasureType,
                        Quantity = ingredient.Quantity
                    });
                }
            }

            await _context.SaveChangesAsync();

            return _mapper.Map<RecipesDto>(entity);
        }

        public async Task<GetRecipesDto> GetRecipeByIdAsync(int id)
        {
            var entity = await _context.Recipe.Where(i => i.IsDeleted == false).Select(r =>
            new GetRecipesDto
            {
                Id = r.Id,
                Name = r.Name,
                Description = r.Description,
                RecipeIngredients = r.RecipeIngredients.Select(i => new GetRecipeIngredientDto
                {
                    IngredinetId = i.IngredientId,
                    Measure = i.MeasureType,
                    Name = i.Ingredient.Name,
                    Quantity = i.Quantity,
                    RecipeId = i.RecipeId,
                    Cost = _recipeIngredientPriceService.IngredientPrice(i)
                }).ToList(),
                TotalCost = _recipeIngredientPriceService.RecipePrice(r)

            }).FirstOrDefaultAsync(i => i.Id == id);
            return entity;
        }
    }
}
