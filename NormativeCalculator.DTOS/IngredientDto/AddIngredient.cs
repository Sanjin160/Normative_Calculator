using NormativeCalculator.Common.Enum;
using NormativeCalculator.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.DTOs.IngredientDto
{
    public class AddIngredient
    {
        public string Name { get; set; } 
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public MeasureType measureType { get; set; } = 0;
    }
}
