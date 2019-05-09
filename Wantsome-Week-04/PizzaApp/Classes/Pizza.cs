using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Classes
{
    class Pizza
    {
        public PizzaBase Base { get; set; }
        public List<PizzaTopping> Toppings { get; set; } = new List<PizzaTopping>();

        Pizza(PizzaBase pizzaBase)
        {
            Base = pizzaBase;
        }

        public void AddTopping()
        {
            PizzaTopping newTopping;
        }

        decimal CalculateTotalCost()
        {

        }

        void Print()
        {

        }
    }
}
