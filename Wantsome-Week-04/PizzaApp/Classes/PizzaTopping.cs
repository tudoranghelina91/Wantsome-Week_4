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

        public PizzaTopping(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public void Print()
        {
            OutputHandling.Message($"{Name} ({Cost.ToString("C", CultureInfo.CurrentCulture)})");
        }
    }
}
