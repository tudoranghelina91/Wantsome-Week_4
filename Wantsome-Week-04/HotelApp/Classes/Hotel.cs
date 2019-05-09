using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_04.Handlers;
using HotelApp.Classes;

namespace HotelApp.Classes
{
    public class Hotel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public List<Room> Rooms { get; set; } = new List<Room>();

        public Hotel(string name, string city)
        {
            Name = name;
            City = city;
        }

        public decimal GetPriceForNumberOfRooms(int numberOfRooms)
        {
            decimal total = 0m;
            foreach (Room room in Rooms)
            {
                total += room.Price;
            }

            return total;
        }

        public void Print()
        {
            OutputHandling.Message($"Hotel Name: {Name}");
            OutputHandling.Message($"City: {City}");
            OutputHandling.Message("Rooms");
            OutputHandling.Message("=====");

            foreach (Room room in Rooms)
            {
                room.Print();
                Console.WriteLine();
            }
        }
    }
}
