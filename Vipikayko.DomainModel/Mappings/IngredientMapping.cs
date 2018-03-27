using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Vipikayko.DomainModel.Models;

namespace Vipikayko.DomainModel.Mappings
{
    public class IngredientMapping : IMapping
    {
        public void Map(ModelBuilder builder)
        {
            builder.Entity<Ingredient>().HasKey(x => x.Id);

            builder.Entity<Ingredient>().Property(x => x.Id).IsRequired(true);
            builder.Entity<Ingredient>().Property(x => x.Name).IsRequired(true);
            builder.Entity<Ingredient>().Property(x => x.CalorieCount).IsRequired(true);
            builder.Entity<Ingredient>().Property(x => x.PricePer1000g).IsRequired(true);
        }
    }
}
