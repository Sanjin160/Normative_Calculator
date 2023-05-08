using NormativeCalculator.Common.Enum;
using NormativeCalculator.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.DTOs.IngredientDto
{
    public class UpdateIngredient
    {
        public int Id { get; set; }
        public string Name { get; set; } = null;
        public decimal Price { get; set; } = 0;
        public int Quantity { get; set; } = 0;
        public MeasureType MeasureType { get; set; } = MeasureType.kom;
    }
}
