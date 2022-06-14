﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Database.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
