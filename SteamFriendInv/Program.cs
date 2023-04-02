
using SteamFriendInv;

namespace Program;

internal class Programm
{
    public static async Task Main()
    {
       await InventoryDataProvider.GetInventory();
    }
}