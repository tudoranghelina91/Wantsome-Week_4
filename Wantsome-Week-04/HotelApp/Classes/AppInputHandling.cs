using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp;
using Wantsome_Week_04.Handlers;
using HotelApp.Classes;

namespace HotelApp.Classes
{
    class AppInputHandling
    {
        public static void MenuOptions(List<Hotel> hotels)
        {
            ConsoleKeyInfo cki = Console.ReadKey(true);

            if (cki.Key.Equals(ConsoleKey.D1))
            {
                Console.Clear();
                HotelDatabaseOperations.AddHotel(hotels);
                OutputHandling.Message("HOTEL ADDED", ConsoleColor.Green);
            }

            else if (cki.Key.Equals(ConsoleKey.D2))
            {
                Console.Clear();
                HotelDatabaseOperations.FindRoom(hotels);
            }

            else if (cki.Key.Equals(ConsoleKey.D3))
            {
                Console.Clear();
                HotelDatabaseOperations.DeleteHotel(hotels);
            }

            else if (cki.Key.Equals(ConsoleKey.D4))
            {
                ProgramFlowHandling.Exit("Thank you for using Hotel Administration App");
                Console.ReadKey();
                return;
            }

            else
            {
                Console.Clear();
                AppFlowHandling.MainMenu(hotels);
            }
        }
    }
}
