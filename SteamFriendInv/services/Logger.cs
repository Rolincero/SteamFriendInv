using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamFriendInv.services
{
    internal static  class Logger
    {
        public static void Info(string message)
        {
            Console.WriteLine($"{DateTime.Now} INFO || {message}");
        }
        public static void Error(string message)
        {
            Console.WriteLine($"{DateTime.Now} ERROR || {message}");
        }
    }
}
