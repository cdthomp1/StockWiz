using StockWiz.Features.Update.Services.Interfaces;
using StockWiz.Features.Update.Services;

namespace StockWiz.Features.Update;

public static class DependencyInjection
{
    public static IServiceCollection AddUpdate(this IServiceCollection services)
    {
        services.AddScoped<IInventoryUpdateService, InventoryUpdateService>();

        return services;
    }
}
