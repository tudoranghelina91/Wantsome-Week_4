using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Wantsome_Week_04.Handlers;

namespace PizzaApp.Classes
{
    class PizzaTopping
    {

        public string Name { get; set; }
        public decimal Cost { get; set; }
        string price = "";

        PizzaTopping(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
            price = Cost.ToString("C2", CultureInfo.CurrentCulture);
        }

        void Print()
        {
            OutputHandling.Message($"{Name} ({price})");
        }
    }
}
