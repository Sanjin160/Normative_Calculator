using NormativeCalculator.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Database.Entities
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public MeasureType MeasureType { get; set; } = MeasureType.ml;
        public IEnumerable<RecipeIngredients> RecipeIngredients { get; set; }
    }
}
