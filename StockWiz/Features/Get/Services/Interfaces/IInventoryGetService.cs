using StockWiz.Features.Common.Models;

namespace StockWiz.Features.Get.Services.Interfaces
{
    public interface IInventoryGetService
    {
        // General item methods
        Task<List<Item>> GetAllItems();
        Task<Item> GetItemById(int id);

        // Grocery item methods
        Task<List<GroceryItem>> GetGroceryItems();
        Task<GroceryItem> GetGroceryItemById(int id);

        // Electronic item methods
        Task<List<ElectronicItem>> GetElectronicItems();
        Task<ElectronicItem> GetElectronicItemById(int id);
    }
}
