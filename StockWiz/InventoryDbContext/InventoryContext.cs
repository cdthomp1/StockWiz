using Microsoft.EntityFrameworkCore;
using StockWiz.Features.Common.Models;

namespace StockWiz.InventoryDbContext
{
    public class InventoryContext : DbContext
    {
        // Constructor that accepts DbContextOptions and passes it to the base DbContext class
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<ElectronicItem> ElectronicItems { get; set; }
        public DbSet<GroceryItem> GroceryItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .HasDiscriminator<string>("ItemType")
                .HasValue<ElectronicItem>("Electronic")
                .HasValue<GroceryItem>("Grocery");
        }
    }
}
