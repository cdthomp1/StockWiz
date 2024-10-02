using Microsoft.EntityFrameworkCore;
using StockWiz.Features.Common.Models;
using StockWiz.Features.Get.Services.Interfaces;
using StockWiz.InventoryDbContext;

namespace StockWiz.Features.Get.Services
{
    public class InventoryGetService : IInventoryGetService
    {
        private readonly InventoryContext _context;

        public InventoryGetService(InventoryContext context)
        {
            _context = context;
        }

        // Get all items
        public async Task<List<Item>> GetAllItems()
        {
            return await _context.Items.ToListAsync();
        }

        // Get item by ID
        public async Task<Item> GetItemById(int id)
        {
            return await _context.Items.FindAsync(id);
        }

        // Get all grocery items
        public async Task<List<GroceryItem>> GetGroceryItems()
        {
            return await _context.GroceryItems.ToListAsync();
        }

        // Get grocery item by ID
        public async Task<GroceryItem> GetGroceryItemById(int id)
        {
            return await _context.GroceryItems.FindAsync(id);
        }

        // Get all electronic items
        public async Task<List<ElectronicItem>> GetElectronicItems()
        {
            return await _context.ElectronicItems.ToListAsync();
        }

        // Get electronic item by ID
        public async Task<ElectronicItem> GetElectronicItemById(int id)
        {
            return await _context.ElectronicItems.FindAsync(id);
        }
    }
}
