using NormativeCalculator.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.DTOs.Request
{
    public class GetRecipeIngredientDto
    {
        public int RecipeId { get; set; }   
        public int IngredinetId { get; set; }   
        public MeasureType Measure { get; set; } 
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
        public string Name { get; set; }
    }
}
