using NormativeCalculator.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.DTOs.IngredientDto
{
    public class GetIngredientDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public MeasureType MeasureType { get; set; } = MeasureType.ml;
    }
}
