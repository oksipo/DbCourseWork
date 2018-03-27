using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Vipikayko.DomainModel.Models;

namespace Vipikayko.DomainModel.Mappings
{
    public class FoodMapping : IMapping
    {
        public void Map(ModelBuilder builder)
        {
            builder.Entity<Food>().HasKey(x => x.Id);

            builder.Entity<Food>().Property(x => x.Id).IsRequired(true);
            builder.Entity<Food>().Property(x => x.Name).IsRequired(true);
            builder.Entity<Food>().Property(x => x.Calories).IsRequired(true);
            builder.Entity<Food>().Property(x => x.Price).IsRequired(true);
        }
    }
}
