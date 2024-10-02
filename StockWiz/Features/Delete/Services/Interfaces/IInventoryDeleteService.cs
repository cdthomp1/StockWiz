using System.Threading.Tasks;

namespace StockWiz.Features.Delete.Services.Interfaces
{
    public interface IInventoryDeleteService
    {
        Task<bool> DeleteItemAsync(int id);
        Task<bool> DeleteElectronicItemAsync(int id);
        Task<bool> DeleteGroceryItemAsync(int id);
    }
}
