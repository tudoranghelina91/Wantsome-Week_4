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
        enum Name { Regular, Thick, Italian}
        public decimal Cost { get; set; }
        public int name;

        public PizzaBase(int name, decimal cost)
        {
       
            Cost = (name != (int)Name.Italian) ? cost : cost * 1.5m;
            this.name = name;
        }

        public void Print()
        {
            if (name == 0)
            {
                OutputHandling.Message($"{Name.Regular} ({Cost.ToString("C", CultureInfo.CurrentCulture)})");
            }

            else if (name == 1)
            {
                OutputHandling.Message($"{Name.Thick} ({Cost.ToString("C", CultureInfo.CurrentCulture)})");
            }

            else
            {
                OutputHandling.Message($"{Name.Italian} ({Cost.ToString("C", CultureInfo.CurrentCulture)})");
            }
        }
    }
}
