using CatShopAPI.Models;

namespace CatShopAPI.Services;

public interface ICatalogService
{
    public CatalogItem[] GetCatalog();
    public void AddItem(string name, string price);
}

public class CatalogService : ICatalogService
{
    private List<CatalogItem> _catalogItems = new();

    public CatalogService()
    {
        AddItem("Krabpaal", "23,75");
        AddItem("Krabbal", "32,79");
        AddItem("Denkspeelgoed", "32,79");
        AddItem("Catnip Bellenblaas", "5,99");
        AddItem("Kattentunnel", "79,99");
        AddItem("Katten Loopwiel", "259,-");
        AddItem("Turning Feather", "22,99");
        AddItem("Pinwheel", "9,99");
        AddItem("Ball Race", "17,99");
        AddItem("Krab Ligplaats", "39,99");
        AddItem("Krabmat met Speeltjes", "19,99");
        AddItem("Krabton Gerardo", "159,-");
    }
    
    public CatalogItem[] GetCatalog()
        => _catalogItems.ToArray();

    public void AddItem(string name, string price)
    {
        var item = new CatalogItem
        {
            Name = name,
            Price = price
        };
        
        _catalogItems.Add(item);
    }
}