using Microsoft.EntityFrameworkCore;
using Vipikayko.DomainModel.Models;

namespace Vipikayko.DomainModel.Mappings
{
    public class CityMapping : IMapping
    {
        public void Map(ModelBuilder builder)
        {
            builder.Entity<City>().HasKey(x => x.Id);

            builder.Entity<City>().Property(x => x.Name).HasColumnName("Name").IsRequired();

            builder.Entity<City>().HasMany(x => x.Addresses).WithOne(x => x.City).HasForeignKey(x => x.CityId);
        }
    }
}
