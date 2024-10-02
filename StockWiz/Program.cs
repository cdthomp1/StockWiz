using StockWiz;

await WebApplication.CreateBuilder(args)
    .ConfigureServices()
    .ConfigureApplication()
    .RunAsync();