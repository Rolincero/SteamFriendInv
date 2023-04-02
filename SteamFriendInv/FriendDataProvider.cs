using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Text.Json.Nodes;

namespace SteamFriendInv
{
	public static class FriendDataProvider
	{
		public static async Task Get(string API, string steam_id)
		{
			string url = $"https://api.steampowered.com/ISteamUser/GetFriendList/v1/?key={API}&steamid={steam_id}";

			HttpClient client = new HttpClient();

			var response = await client.GetAsync(url);
			response.EnsureSuccessStatusCode();
			var data = await response.Content.ReadAsStringAsync();
			Console.WriteLine(data);

			var result = new JsonArray();
			result.Add(data);
			Console.WriteLine(result);
        }
	}

	//private class Friend
	//{
	//	private decimal _steam_id { get; set; }
	//	private string? _relationship { get; set; }
	//	private decimal _friend_since { get; set; }
	//}
}
