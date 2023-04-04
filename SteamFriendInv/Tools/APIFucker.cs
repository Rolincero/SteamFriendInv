using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamFriendInv.Tools
{
    internal class APIFucker
    {
        private static string API = "2D436A4837330DAE1CBD96D1FC1C0683";
        private static string ST_ID = "76561198068488288";
        private static string url = $"http://steamcommunity.com/inventory/76561199026249930/570/2?l=english&count=5000";
        private static HttpClient client = new HttpClient();
        private static int Count = 0;
        private static int BaseTime = 120000;
        private static bool succes = false;
        public static async Task LetsFuck()
        {
            while (true)
            {
                var response = await client.GetAsync(url);
                try
                {
                    response.EnsureSuccessStatusCode();
                }
                catch (Exception Ex)
                {
                    Debug.WriteLine(Ex.Message);
                }

                var data = await response.Content.ReadAsStringAsync();
                if (response.StatusCode is System.Net.HttpStatusCode.OK)
                {
                    Count++;
                    Debug.WriteLine("Fucked");
                    succes = true;
                    Thread.Sleep(BaseTime);
                    Logger();
                }
                else
                {
                    succes = false;
                    //BaseTime += 5000;
                    Thread.Sleep(BaseTime);
                    Logger();
                }
            }
        }

        public static void Logger() => Debug.WriteLine($"Count: {Count} || BaseTime: {BaseTime} || Succes: {succes}");
    }
}
