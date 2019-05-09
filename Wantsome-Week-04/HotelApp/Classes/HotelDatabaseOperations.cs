using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_04.Handlers;
using HotelApp;

namespace HotelApp.Classes
{

    public class HotelDatabaseOperations
    {
        public static void AddHotel(List<Hotel> hotels)
        {
            string hotelName = HotelInputHandling.AddHotelName();
            string hotelCity = HotelInputHandling.AddHotelCity();
            Hotel hotel = new Hotel(hotelName, hotelCity);
            HotelInputHandling.AddHotelRooms(hotel);
            hotels.Add(hotel);

            OutputHandling.Message("The following hotel has been added!");
            hotel.Print();
            // ENCAPSULATE THIS
            OutputHandling.Message("Press any key to return to the main menu...", ConsoleColor.Green);
            Console.ReadKey();
            Console.Clear();
            Program.MainMenu(hotels);
        }

        public static void DeleteHotel(List<Hotel> hotels)
        {
            // Encapsulate this
            int hotelctr = 1;
            foreach (Hotel hotel in hotels)
            {
                OutputHandling.Message($"{hotelctr}. {hotel.Name}");
                hotelctr++;
            }

            // Encapsulate this
            OutputHandling.Message("Type in the number of the hotel to delete: ");
            int hotelNumber = InputHandling.ReadValue("Type in the number of the hotel to delete: ");

            if (hotelNumber > hotels.Count || hotelNumber < hotels.Count)
            {
                OutputHandling.Error("Invalid hotel ID!");
            }

            else
            {
                OutputHandling.Message($"{hotels[hotelNumber-1].Name} has been removed successfully", ConsoleColor.Green);
                hotels.Remove(hotels[hotelNumber-1]);
            }

            Program.MainMenu(hotels);
        }

        public static void FindRoom(List<Hotel> hotels)
        {
            int roomcount = 0;

            decimal budget = InputHandling.ReadValueD("Budget: ");
            foreach (Hotel hotel in hotels)
            {
                Hotel currentHotel = hotel;
                foreach (Room room in currentHotel.Rooms)
                {
                    if (room.Price < budget)
                    {
                        OutputHandling.Message($"Hotel Name: {currentHotel.Name}");
                        room.Print();
                        Console.WriteLine();
                        roomcount++;
                    }
                }
            }

            OutputHandling.Message($"We found {roomcount} rooms that match your criteria!", ConsoleColor.Green);
            // ENCAPSULATE THIS
            OutputHandling.Message("Press any key to return to the main menu...", ConsoleColor.Green);
            Console.ReadKey();
            Console.Clear();
            Program.MainMenu(hotels);
        }
    }
}
