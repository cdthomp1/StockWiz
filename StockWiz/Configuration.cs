using Microsoft.EntityFrameworkCore;
using StockWiz.Features.Common.Repository;
using StockWiz.Features.Common.Repository.Interfaces;
using StockWiz.Features.Create;
using StockWiz.Features.Delete;
using StockWiz.Features.Get;
using StockWiz.Features.Update;
using StockWiz.InventoryDbContext;

namespace StockWiz;

public static class Configuration
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        // Add EF Core with SQLite
        builder.Services.AddDbContext<InventoryContext>(options =>
            options.UseSqlite("Data Source=inventory.db"));

        builder.Services.AddControllers();

        // Repositories
        builder.Services.AddScoped<IItemRepository, ItemRepository>();

        // Services
        builder.Services.AddGet();
        builder.Services.AddCreate();
        builder.Services.AddDelete();
        builder.Services.AddUpdate();

        return builder.Build();
    }

    public static WebApplication ConfigureApplication(this WebApplication app)
    {
        // Middleware for development error pages
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.MapControllers();

        return app;
    }
}
