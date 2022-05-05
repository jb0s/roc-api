using CatShopAPI.Models;
using CatShopAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CatShopAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ShopController : ControllerBase
{
    private readonly ILogger<ShopController> _logger;
    private readonly ICatalogService _catalogService;

    public ShopController(ILogger<ShopController> logger, ICatalogService catalogService)
    {
        _logger = logger;
        _catalogService = catalogService;
    }

    [HttpGet("catalog")]
    public CatalogItem[] GetCatalog()
    {
        Response.Headers.Add("Access-Control-Allow-Origin", "*");
        return _catalogService.GetCatalog();
    }
}