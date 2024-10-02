using StockWiz.InventoryDbContext;
using StockWiz.Features.Delete.Services.Interfaces;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StockWiz.Features.Delete.Services
{
    public class InventoryDeleteService : IInventoryDeleteService
    {
        private readonly InventoryContext _context;

        public InventoryDeleteService(InventoryContext context)
        {
            _context = context;
        }

        // Method to delete a general item by ID
        public async Task<bool> DeleteItemAsync(int id)
        {
            var item = await _context.Items.FindAsync(id);
            if (item == null)
            {
                return false;
            }

            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
            return true;
        }

        // Method to delete an electronic item by ID
        public async Task<bool> DeleteElectronicItemAsync(int id)
        {
            var electronicItem = await _context.ElectronicItems.FindAsync(id);
            if (electronicItem == null)
            {
                return false;
            }

            _context.ElectronicItems.Remove(electronicItem);
            await _context.SaveChangesAsync();
            return true;
        }

        // Method to delete a grocery item by ID
        public async Task<bool> DeleteGroceryItemAsync(int id)
        {
            var groceryItem = await _context.GroceryItems.FindAsync(id);
            if (groceryItem == null)
            {
                return false;
            }

            _context.GroceryItems.Remove(groceryItem);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
