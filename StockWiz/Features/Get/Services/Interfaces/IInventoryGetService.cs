using StockWiz.Features.Common.Models;

namespace StockWiz.Features.Get.Services.Interfaces
{
    public interface IInventoryGetService
    {
        public Task<List<Item>> GetAllItems();
        public Task<Item> GetItemById(int id);
    }
}
