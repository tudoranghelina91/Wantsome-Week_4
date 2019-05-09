using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Wantsome_Week_04.Handlers;

namespace PizzaApp.Classes
{
    public class PizzaBase
    {
        string Name { get; set; }
        public decimal Cost { get; set; }
        string price = "";

        public PizzaBase(string name, decimal cost)
        {
            Name = name;
            Cost = (Name != "Italian") ? cost : cost * 1.5m;
            price = Cost.ToString("C2", CultureInfo.CurrentCulture);
        }

        public void Print()
        {
            OutputHandling.Message($"{Name} ({price})");
        }
    }
}
