using System;
using Microsoft.EntityFrameworkCore;

namespace UpgradeParadeTT.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Product Name 1", Price = 100 },
                new Product { Id = 2, Name = "Product Name 2", Price = 10 },
                new Product { Id = 3, Name = "Product Name 3", Price = 5 },
                new Product { Id = 4, Name = "Product Name 4", Price = 50 },
                new Product { Id = 5, Name = "Product Name 5", Price = 500 });
        }
    }
}
