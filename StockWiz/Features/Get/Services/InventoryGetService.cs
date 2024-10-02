using Microsoft.EntityFrameworkCore;
using StockWiz.Features.Common.Models;
using StockWiz.Features.Get.Services.Interfaces;
using StockWiz.InventoryDbContext;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockWiz.Features.Get.Services;

public class InventoryGetService(InventoryContext context) : IInventoryGetService
{
    // Method to get all items from the database
    public async Task<List<Item>> GetAllItems()
    {
        return await context.Items.ToListAsync(); // Fetches all items from the database
    }

    // Method to get a specific item by its ID
    public async Task<Item> GetItemById(int id)
    {
        return await context.Items.FindAsync(id); // Fetches item by ID, returns null if not found
    }
}
