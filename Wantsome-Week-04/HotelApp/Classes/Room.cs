using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_04.Handlers;

namespace HotelApp.Classes
{
    public class Room
    {

        public decimal Price { get; set; }
        public string Name { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public Rate rate { get; set; }
        public bool Booked { get; set; } = false;

        public Room(decimal price, string name, int adults, int children)
        {
            Price = price;
            Name = name;
            Adults = adults;
            Children = children;
            rate = new Rate(price);
        }
        decimal GetPricesForDays(int numberOfDays)
        {
            return numberOfDays * Price;
        }

        public void Print()
        {
            OutputHandling.Message($"Room Name: {Name}");
            OutputHandling.Message($"Rate: {rate.price}");
            OutputHandling.Message($"Adults: {Adults}");
            OutputHandling.Message($"Children: {Children}");
        }
    }
}
