using System;
using System.Collections.Generic;
using System.Text;

namespace Vipikayko.DomainModel.Models
{
    public class Ingredient
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public double CalorieCount { get; set; }

        public double PricePer1000g { get; set; }
    }
}
