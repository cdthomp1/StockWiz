using StockWiz.Features.Get.Services;
using StockWiz.Features.Get.Services.Interfaces;

namespace StockWiz.Features.Get;

public static class DependencyInjection
{
    public static IServiceCollection AddGet(this IServiceCollection services)
    {
        services.AddScoped<IInventoryGetService, InventoryGetService>();
        return services;
    }
}
