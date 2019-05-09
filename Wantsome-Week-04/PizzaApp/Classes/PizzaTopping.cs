using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Wantsome_Week_04.Handlers;

namespace PizzaApp.Classes
{
    public class PizzaTopping
    {

        public string Name { get; set; }
        public decimal Cost { get; set; }
        string price = "";

        public PizzaTopping(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
            price = Cost.ToString("C2", CultureInfo.CurrentCulture);
        }

        public void Print()
        {
            OutputHandling.Message($"{Name} ({price})");
        }
    }
}
