using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Vipikayko.DomainModel.Models;

namespace Vipikayko.DomainModel.Mappings
{
    public class ClientMapping : IMapping
    {
        public void Map(ModelBuilder builder)
        {
            builder.Entity<Client>().HasKey(x => x.AddressId);

            builder.Entity<Client>().Property(x => x.AddressId).IsRequired(true).ValueGeneratedNever();
            builder.Entity<Client>().Property(x => x.ContactPhone).IsRequired(true);
            builder.Entity<Client>().Property(x => x.ContactName).IsRequired(false);

            builder.Entity<Client>().HasOne(x => x.Address).WithMany()
                .HasForeignKey(x => x.AddressId);
        }
    }
}
