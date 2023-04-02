using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamFriendInv
{
    internal static class InventoryDataProvider
    {
        private static HttpClient _client = new HttpClient();

        public static async Task GetInventory(string steamId)
        {
            string url = $"http://steamcommunity.com/inventory/{steamId}/570/2?l=english&count=5000";

            HttpResponseMessage response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            Console.WriteLine(data);

        }
    }
}
