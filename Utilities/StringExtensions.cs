using System.Text;

namespace CatShopAPI.Utilities;

public static class StringExtensions
{
    public static string RemoveSpecialCharacters(this string str) {
        var sb = new StringBuilder();
        foreach (var c in str.Where(c => c is >= '0' and <= '9' or >= 'A' and <= 'Z' or >= 'a' and <= 'z' or '-'))
            sb.Append(c);
        
        return sb.ToString();
    }
}