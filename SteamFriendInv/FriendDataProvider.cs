using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Text.Json.Nodes;
using System.Text.Json;

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
		}
	}

	//public class Friend
	//{
	//	private string _steam_id { get; set; }
	//	private string _relationship { get; set; }
	//	private string _friend_since { get; set; }

	//       public Friend(string id, string rel, string frnd_since)
	//       {
	//           _steam_id = id;
	//		_relationship = rel;
	//		_friend_since = frnd_since;
	//       }
	//   }
}
