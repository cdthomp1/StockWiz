using StockWiz.Features.Common.Models;

namespace StockWiz.Features.Create.Services.Interfaces
{
    public interface IInventoryCreateService
    {
        public Task<Item> CreateItemAsync(Item item);
        public Task<ElectronicItem> CreateElectronicItemAsync(ElectronicItem electronicItem);
        public Task<GroceryItem> CreateGroceryItemAsync(GroceryItem groceryItem);
    }
}
