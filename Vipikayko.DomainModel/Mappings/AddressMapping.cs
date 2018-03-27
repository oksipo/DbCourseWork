using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Vipikayko.DomainModel.Models;

namespace Vipikayko.DomainModel.Mappings
{
    public class AddressMapping : IMapping
    {
        public void Map(ModelBuilder builder)
        {
            builder.Entity<Address>().HasKey(x => x.Id);

            builder.Entity<Address>().Property(x => x.Id).HasColumnName("Id").IsRequired(true);
            builder.Entity<Address>().Property(x => x.StreetName).HasColumnName("StreetName").IsRequired(true);
            builder.Entity<Address>().Property(x => x.House).HasColumnName("House").IsRequired(true);
            builder.Entity<Address>().Property(x => x.Flat).HasColumnName("Flat").IsRequired(false);
            builder.Entity<Address>().Property(x => x.CityId).HasColumnName("CityId").IsRequired(true);
            
        }
    }
}
