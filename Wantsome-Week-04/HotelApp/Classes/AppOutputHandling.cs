using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_04.Handlers;

namespace HotelApp.Classes
{
    class AppOutputHandling
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("Welcome to Hotel Administration App");
            Console.WriteLine("1. Add Hotel");
            Console.WriteLine("2. Find a Room");
            Console.WriteLine("3. Delete a hotel");
            Console.WriteLine("4. Exit");
        }

        public static void DisplayHotels(List<Hotel> hotels)
        {
            int hotelctr = 1;
            foreach (Hotel hotel in hotels)
            {
                OutputHandling.Message($"{hotelctr}. {hotel.Name}");
                hotelctr++;
            }
        }
    }
}
