using StockWiz.Features.Create.Services.Interfaces;
using StockWiz.Features.Create.Services;

namespace StockWiz.Features.Create
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCreate(this IServiceCollection services)
        {
            services.AddScoped<IInventoryCreateService, InventoryCreateService>();

            return services;
        }
    }
}
