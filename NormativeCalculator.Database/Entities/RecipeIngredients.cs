using NormativeCalculator.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Database.Entities
{
    public class RecipeIngredients
    {

        [ForeignKey("RecipeId")]
        public Recipe Recipe { get; set; }
        public int RecipeId { get; set; }

        [ForeignKey("IngredientId")]
        public Ingredient Ingredient { get; set; }
        public int IngredientId { get; set; }
        public int Quantity { get; set; }
        public MeasureType MeasureType { get; set; }
    }
}
