using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_04.Handlers;

namespace HotelApp.Classes.AppHandling
{
    class AppFlowHandling
    {
        public static void ReturnToMainMenu(List<Hotel> hotels)
        {
            // ENCAPSULATE THIS
            OutputHandling.Message("Press any key to return to the main menu...", ConsoleColor.Green);
            Console.ReadKey();
            Console.Clear();
            MainMenu(hotels);
        }

        public static void MainMenu(List<Hotel> hotels)
        {
            AppOutputHandling.DisplayMenu();
            AppInputHandling.MenuOptions(hotels);
        }
    }
}
