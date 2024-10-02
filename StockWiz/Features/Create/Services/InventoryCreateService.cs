using StockWiz.Features.Common.Models;
using StockWiz.Features.Create.Services.Interfaces;
using StockWiz.InventoryDbContext;

namespace StockWiz.Features.Create.Services
{
    public class InventoryCreateService : IInventoryCreateService
    {
        private readonly InventoryContext _context;

        // Injecting the DbContext via constructor
        public InventoryCreateService(InventoryContext context)
        {
            _context = context;
        }

        // Method to add a new item to the inventory
        public async Task<Item> CreateItemAsync(Item item)
        {
            _context.Items.Add(item); // Adds the item to the context
            await _context.SaveChangesAsync(); // Persists changes to the database
            return item; // Returns the added item
        }

        // Method to add a new electronic item to the inventory
        public async Task<ElectronicItem> CreateElectronicItemAsync(ElectronicItem electronicItem)
        {
            _context.ElectronicItems.Add(electronicItem); // Adds the electronic item to the context
            await _context.SaveChangesAsync(); // Persists changes to the database
            return electronicItem; // Returns the added electronic item
        }

        // Method to add a new grocery item to the inventory
        public async Task<GroceryItem> CreateGroceryItemAsync(GroceryItem groceryItem)
        {
            _context.GroceryItems.Add(groceryItem); // Adds the grocery item to the context
            await _context.SaveChangesAsync(); // Persists changes to the database
            return groceryItem; // Returns the added grocery item
        }
    }
}
