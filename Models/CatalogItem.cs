using CatShopAPI.Utilities;
using System.Text.Json.Serialization;

namespace CatShopAPI.Models;

public class CatalogItem
{
    [JsonPropertyName("id")]
    public string Id => Name.Replace(" ", "-").RemoveSpecialCharacters().ToLower();
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("price")]
    public string Price { get; set; }
}