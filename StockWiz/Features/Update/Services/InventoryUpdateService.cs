using StockWiz.InventoryDbContext;
using StockWiz.Features.Update.Services.Interfaces;
using StockWiz.Features.Common.Models;

namespace StockWiz.Features.Update.Services
{
    public class InventoryUpdateService : IInventoryUpdateService
    {
        private readonly InventoryContext _context;

        public InventoryUpdateService(InventoryContext context)
        {
            _context = context;
        }

        // Method to update a general item by ID
        public async Task<Item> UpdateItemAsync(int id, Item item)
        {
            var existingItem = await _context.Items.FindAsync(id);
            if (existingItem == null)
            {
                return null; // Item not found
            }

            // Update properties of the existing item
            _context.Entry(existingItem).CurrentValues.SetValues(item);
            await _context.SaveChangesAsync();

            return existingItem; // Return the updated item
        }

        // Method to update an electronic item by ID
        public async Task<ElectronicItem> UpdateElectronicItemAsync(int id, ElectronicItem electronicItem)
        {
            var existingElectronicItem = await _context.ElectronicItems.FindAsync(id);
            if (existingElectronicItem == null)
            {
                return null; // Electronic item not found
            }

            // Update properties of the existing electronic item
            _context.Entry(existingElectronicItem).CurrentValues.SetValues(electronicItem);
            await _context.SaveChangesAsync();

            return existingElectronicItem; // Return the updated electronic item
        }

        // Method to update a grocery item by ID
        public async Task<GroceryItem> UpdateGroceryItemAsync(int id, GroceryItem groceryItem)
        {
            var existingGroceryItem = await _context.GroceryItems.FindAsync(id);
            if (existingGroceryItem == null)
            {
                return null; // Grocery item not found
            }

            // Update properties of the existing grocery item
            _context.Entry(existingGroceryItem).CurrentValues.SetValues(groceryItem);
            await _context.SaveChangesAsync();

            return existingGroceryItem; // Return the updated grocery item
        }
    }
}
