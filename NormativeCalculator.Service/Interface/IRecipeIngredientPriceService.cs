using NormativeCalculator.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Service.Interface
{
    public interface IRecipeIngredientPriceService
    {
        public decimal IngredientPrice(RecipeIngredients request);
        public decimal RecipePrice(Recipe request);
    }
}
