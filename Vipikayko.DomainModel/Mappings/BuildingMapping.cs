using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Vipikayko.DomainModel.Models;

namespace Vipikayko.DomainModel.Mappings
{
    public class BuildingMapping : IMapping
    {
        public void Map(ModelBuilder builder)
        {
            builder.Entity<Building>().HasKey(x => x.Id);

            builder.Entity<Building>().Property(x => x.Id).IsRequired(true);
            builder.Entity<Building>().Property(x => x.AddressId).IsRequired(true);
            builder.Entity<Building>().Property(x => x.Type).IsRequired(true);

            builder.Entity<Building>().HasOne(x => x.Address).WithMany().HasForeignKey(x => x.AddressId);

        }
    }
}
