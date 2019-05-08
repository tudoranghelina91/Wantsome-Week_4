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
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }

        string name;
        decimal rate;
        int adults;
        int children;

        decimal GetPricesForDays(int numberOfDays)
        {
            return numberOfDays * rate;
        }

        public void Print()
        {
            OutputHandling.Message($"Name: {this.name}");
            OutputHandling.Message($"Rate: {this.rate}");
            OutputHandling.Message($"Adults: {this.adults}");
            OutputHandling.Message($"Children: {this.children}");
        }
    }
}
