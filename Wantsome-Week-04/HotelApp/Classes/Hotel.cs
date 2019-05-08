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
        public Room[] Rooms { get; set; }

        string name;
        string city;
        Room[] rooms;

        public decimal GetPriceForNumberOfRooms(int numberOfRooms)
        {
            decimal total = 0m;
            foreach (Room room in rooms)
            {
                total += room.Rate;
            }

            // TODO calculations
            return total;
        }

        public void Print()
        {
            OutputHandling.Message($"Name: {this.name}");
            OutputHandling.Message($"City: {this.name}");
            OutputHandling.Message("Rooms");
            OutputHandling.Message("=====");

            foreach (Room room in rooms)
            {
                room.Print();
                Console.WriteLine();
            }
        }
    }
}
