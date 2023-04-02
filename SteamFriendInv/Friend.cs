using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace SteamFriendInv
{
	internal class Friend
	{
		public void Get(string API, string steam_id)
		{
			string url = "https://api.steampowered.com/ISteamUser/GetFriendList/v1/?key=%7Bapi_key%7D&steamid=%7Bsteam_id%7D";

			HttpClient client = new HttpClient();

			client.GetAsync(url).Wait();
            Console.WriteLine("Status: " + (int)client.GetAsync(url));
        }
	}
}
