using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Vipikayko.DomainModel.Models;

namespace Vipikayko.DomainModel.Mappings
{
    public class FoodIngredientMapping : IMapping
    {
        public void Map(ModelBuilder builder)
        {
            builder.Entity<FoodIngredient>().HasKey(x => new {x.FoodId, x.IngredientId});

            builder.Entity<FoodIngredient>().Property(x => x.FoodId).IsRequired(true).ValueGeneratedNever();
            builder.Entity<FoodIngredient>().Property(x => x.IngredientId).IsRequired(true).ValueGeneratedNever();
            builder.Entity<FoodIngredient>().Property(x => x.Count).IsRequired(true);

            builder.Entity<FoodIngredient>().HasOne(x => x.Ingredient).WithMany().HasForeignKey(x => x.IngredientId);
            builder.Entity<FoodIngredient>().HasOne(x => x.Food).WithMany().HasForeignKey(x => x.FoodId);
        }
    }
}
