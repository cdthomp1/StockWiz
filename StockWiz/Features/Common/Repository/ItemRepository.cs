using Microsoft.EntityFrameworkCore;
using StockWiz.Features.Common.Models;
using StockWiz.Features.Common.Repository.Interfaces;
using StockWiz.InventoryDbContext;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockWiz.Features.Common.Repository;

public class ItemRepository : IItemRepository
{
    private readonly InventoryContext _context;

    // Injecting the DbContext via constructor
    public ItemRepository(InventoryContext context)
    {
        _context = context;
    }

    // Add a new item to the inventory
    public async Task<Item> AddItemAsync(Item item)
    {
        _context.Items.Add(item);
        await _context.SaveChangesAsync(); // Save changes to the database
        return item;
    }

    // Get all items or search by name (optional filter)
    public async Task<IEnumerable<Item>> GetItemsAsync(string search = null)
    {
        if (string.IsNullOrEmpty(search))
        {
            return await _context.Items.ToListAsync(); // Return all items if no search query is provided
        }
        else
        {
            return await _context.Items
                .Where(i => i.Name.Contains(search)) // Filter items by name
                .ToListAsync();
        }
    }

    // Get an item by its ID
    public async Task<Item> GetItemByIdAsync(int id)
    {
        return await _context.Items.FindAsync(id); // Find item by its primary key (ID)
    }

    // Update an existing item
    public async Task<Item> UpdateItemAsync(Item item)
    {
        var existingItem = await _context.Items.FindAsync(item.Id); // Find existing item by ID
        if (existingItem != null)
        {
            _context.Entry(existingItem).CurrentValues.SetValues(item); // Update the item
            await _context.SaveChangesAsync(); // Save changes to the database
            return existingItem;
        }

        return null; // Item not found
    }

    // Delete an item from the inventory
    public async Task<bool> DeleteItemAsync(int id)
    {
        var item = await _context.Items.FindAsync(id); // Find item by ID
        if (item != null)
        {
            _context.Items.Remove(item); // Remove the item from the DbSet
            await _context.SaveChangesAsync(); // Save changes to the database
            return true;
        }

        return false; // Item not found
    }
}
