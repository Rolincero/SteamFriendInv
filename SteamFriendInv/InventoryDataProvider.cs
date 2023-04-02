
using System.Text.Json;
using System.Text.Json.Nodes;

namespace SteamFriendInv;

internal static class InventoryDataProvider
{
    private static HttpClient _client = new HttpClient();

    public static async Task GetInventory(string steamId = "76561198091196677")
    {
        //string url = $"http://steamcommunity.com/inventory/{steamId}/570/2?l=english&count=5000";
        //string url = "https://steamcommunity.com/inventory/76561198068488288/570/2?l=english";
         string url = "https://jsonplaceholder.typicode.com/todos";


        HttpResponseMessage response = await _client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        var data = await response.Content.ReadAsStringAsync();
        var result = new JsonArray() 
        {
            data
        };
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}

