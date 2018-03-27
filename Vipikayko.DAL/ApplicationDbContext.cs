using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using authresearch.Models;
using Vipikayko.DomainModel;
using Vipikayko.DomainModel.Models;

namespace authresearch.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<City> Cities { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<FoodIngredient> FoodIngredients { get; set; }

        public DbSet<Building> Buildings { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            var helper = new MappingHelper();
            helper.Map(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
