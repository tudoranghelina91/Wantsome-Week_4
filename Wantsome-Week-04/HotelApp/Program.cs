using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.Classes;
using Wantsome_Week_04.Handlers;

namespace HotelApp
{

    class Program
    {
        // Encapsulate this
        public static void MainMenu(List<Hotel> hotels)
        {
            Console.WriteLine("Welcome to Hotel Administration App");
            Console.WriteLine("1. Add Hotel");
            Console.WriteLine("2. Find a room");
            Console.WriteLine("3. Delete a hotel");
            Console.WriteLine("4. Exit");

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
                OutputHandling.Message("Thank you for using Hotel Administration App!!! Press any key to exit...", ConsoleColor.Green);
                Console.ReadKey();
                return;
            }

            else
            {
                Console.Clear();
                MainMenu(hotels);
            }
        }

        static void Main(string[] args)
        {
            List<Hotel> hotels = new List<Hotel>();
            MainMenu(hotels);
        }
    }
}
