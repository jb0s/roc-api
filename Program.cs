using CatShopAPI.Services;

namespace CatShopAPI;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllers();
        builder.Services.AddSingleton<ICatalogService, CatalogService>();
        builder.WebHost.UseUrls("http://*:1110");

        var app = builder.Build();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}