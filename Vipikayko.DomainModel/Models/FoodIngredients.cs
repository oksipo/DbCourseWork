using System;
using System.Collections.Generic;
using System.Text;

namespace Vipikayko.DomainModel.Models
{
    public class FoodIngredient
    {
        public long FoodId { get; set; }

        public long IngredientId { get; set; }

        public double Count { get; set; }

        public Food Food { get; set; }

        public Ingredient Ingredient { get; set; }
    }
}
