using StockWiz.Features.Common.Models;
using System.Threading.Tasks;

namespace StockWiz.Features.Update.Services.Interfaces
{
    public interface IInventoryUpdateService
    {
        Task<Item> UpdateItemAsync(int id, Item item);
        Task<ElectronicItem> UpdateElectronicItemAsync(int id, ElectronicItem electronicItem);
        Task<GroceryItem> UpdateGroceryItemAsync(int id, GroceryItem groceryItem);
    }
}
