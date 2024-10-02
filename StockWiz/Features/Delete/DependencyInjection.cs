using StockWiz.Features.Delete.Services;
using StockWiz.Features.Delete.Services.Interfaces;

namespace StockWiz.Features.Delete
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDelete(this IServiceCollection services)
        {
            services.AddScoped<IInventoryDeleteService, InventoryDeleteService>();

            return services;
        }
    }
}
