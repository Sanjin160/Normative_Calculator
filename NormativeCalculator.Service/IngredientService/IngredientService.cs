using AutoMapper;
using NormativeCalculator.Database.DataSeed;
using NormativeCalculator.Database.Entities;
using NormativeCalculator.DTOs.IngredientDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NormativeCalculator.Database.EF;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.DTOs.Response;

namespace NormativeCalculator.Service.IngredientService
{
    public class IngredientService : IIngredientService
    {
        private readonly IMapper _mapper;
        private readonly NormativeCalculatorDbContext _context;

        public IngredientService(IMapper mapper, NormativeCalculatorDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<List<GetIngredientDto>>> AddIngredient(AddIngredient newIngredient)
        {
            var ServiceResponse = new ServiceResponse<List<GetIngredientDto>>();
            Ingredient ingredient = _mapper.Map<Ingredient>(newIngredient);
            ingredient.IsDeleted = false;
            _context.Ingredients.Add(ingredient);
            await _context.SaveChangesAsync();
            ServiceResponse.Data = await _context.Ingredients
            .Select(c => _mapper.Map<GetIngredientDto>(c)).ToListAsync();
            return ServiceResponse;
        }

        public async Task<ServiceResponse<List<GetIngredientDto>>> DeleteIngredient(int id)
        {
            var ServiceResponse = new ServiceResponse<List<GetIngredientDto>>();

                Ingredient ingredient = await _context.Ingredients.FirstOrDefaultAsync(c => c.Id == id);

                if (ingredient != null)
                {
                    ingredient.IsDeleted = true;

                    await _context.SaveChangesAsync();

                    ServiceResponse.Data = _context.Ingredients
                        .Select(c => _mapper.Map<GetIngredientDto>(c)).ToList();
                }
                else
                {
                    ServiceResponse.Success = false;
                    ServiceResponse.Message = "Ingredient not found.";
                }
                return ServiceResponse;
        }

        public async Task<ServiceResponse<List<GetIngredientDto>>> GetAllIngredients()
        {
            var ServiceResponse = new ServiceResponse<List<GetIngredientDto>>();

            var dbIngredients = await _context.Ingredients.Where(i=> i.IsDeleted==false).ToListAsync();

            ServiceResponse.Data = dbIngredients.Select(c => _mapper.Map<GetIngredientDto>(c)).ToList();
            return ServiceResponse;
        }

        public async Task<ServiceResponse<GetIngredientDto>> GetOneIngredient(int id)
        {
            var ServiceResponse = new ServiceResponse<GetIngredientDto>();
            ServiceResponse.Data = _mapper.Map<GetIngredientDto>(await _context.Ingredients.FirstOrDefaultAsync(c=>c.Id==id));
            return ServiceResponse;
        }

        public async Task<ServiceResponse<GetIngredientDto>> UpdateIngredient(UpdateIngredient updatedIngredient)
        {
            var ServiceResponse = new ServiceResponse<GetIngredientDto>();

                Ingredient ingredient = await _context.Ingredients
                    .FirstOrDefaultAsync(c => c.Id == updatedIngredient.Id);
                if (ingredient.Id == updatedIngredient.Id)
                {

                    ingredient.Name = updatedIngredient.Name;
                    ingredient.Price = updatedIngredient.Price;
                    ingredient.Quantity = updatedIngredient.Quantity;
                    ingredient.MeasureType = updatedIngredient.MeasureType;

                    await _context.SaveChangesAsync();

                    ServiceResponse.Data = _mapper.Map<GetIngredientDto>(ingredient);
                }
                else
                {
                    ServiceResponse.Success = false;
                    ServiceResponse.Message = "Ingredient not found.";
                }

            return ServiceResponse;
        }
    }
}
