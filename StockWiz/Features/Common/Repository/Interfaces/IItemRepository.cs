using StockWiz.Features.Common.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockWiz.Features.Common.Repository.Interfaces;

public interface IItemRepository
{
    // Method to add a new item
    Task<Item> AddItemAsync(Item item);

    // Method to retrieve a list of items, with optional search filter
    Task<IEnumerable<Item>> GetItemsAsync(string search = null);

    // Method to get a specific item by its ID
    Task<Item> GetItemByIdAsync(int id);

    // Method to update an existing item
    Task<Item> UpdateItemAsync(Item item);

    // Method to delete an item by its ID
    Task<bool> DeleteItemAsync(int id);
}
