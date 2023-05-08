using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NormativeCalculator.Common.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MeasureType
    {
        kom = 1,
        kg = 2,
        gr = 3,
        l = 4,
        ml = 5,
    }
}
