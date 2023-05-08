using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.DTOs.Request
{
    public class GetRecipesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal TotalCost { get; set; }
        public IEnumerable<GetRecipeIngredientDto> RecipeIngredients { get; set; }
    }
}
