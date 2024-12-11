using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PizzaShop.Api.Utilities;
using PizzaShop.Core.Entities;

namespace PizzaShop.Core.DbContexts
{
    public class PizzaShopDbContext : DbContext
    {
        private readonly IConfiguration configuration;  

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Pizza> Pizzas { get; set; }

        public DbSet<PizzaSize> PizzaSizes { get; set; }

        public DbSet<PizzaTopping> PizzaToppings { get; set; }


        public PizzaShopDbContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("PizzaShopApiDb"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var e in Enum.GetValues(typeof(PizzaToppingEnum)))
            {
                modelBuilder.Entity<PizzaTopping>().HasData(new PizzaTopping
                {
                    Id = (int)e,
                    Topping = ((PizzaToppingEnum)(int)e).GetDescriptionAttributeFromEnum(typeof(PizzaToppingEnum))
                });
            }

            foreach (var e in Enum.GetValues(typeof(PizzaSizeEnum)))
            {
                modelBuilder.Entity<PizzaSize>().HasData(new PizzaSize
                {
                    Id = (int)e,
                    Size = ((PizzaSizeEnum)(int)e).GetDescriptionAttributeFromEnum(typeof(PizzaSizeEnum))
                });
            }

            foreach (var e in Enum.GetValues(typeof(AddressStateInitialEnum)))
            {
                modelBuilder.Entity<AddressState>().HasData(new AddressState
                {
                    Id = (int)e,
                    StateInitial = e.ToString() ?? string.Empty,
                    StateName = ((AddressStateInitialEnum)(int)e).GetDescriptionAttributeFromEnum(typeof(AddressStateInitialEnum))
                });
            }
        }
    }
}
