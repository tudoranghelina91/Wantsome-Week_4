using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_04.Handlers;
using System.Globalization;

namespace PizzaApp.Classes
{
    public class Pizza
    {
        public string PizzaName { get; set; }
        public PizzaBase Base { get; set; }
        public List<PizzaTopping> Toppings { get; set; } = new List<PizzaTopping>();
        public decimal Cost { get; set; }


        public Pizza(string name, int pizzaBaseName, decimal cost)
        {
            Base = new PizzaBase(pizzaBaseName, cost);
            PizzaName = name;
            CalculateTotalCost(Base.Cost);
        }

        public void AddTopping(string toppingName, decimal cost)
        {
            PizzaTopping newTopping = new PizzaTopping(toppingName, cost);
            Toppings.Add(newTopping);
            CalculateTotalCost(cost);
        }

        public void CalculateTotalCost(decimal cost)
        {
            Cost += cost;
        }

        public void Print()
        {
            OutputHandling.Message($"Pizza {PizzaName}");
            OutputHandling.Message("Base: ", newLine: false);
            Base.Print();
            OutputHandling.Message("Toppings: ");
            foreach (PizzaTopping topping in Toppings)
            {
                OutputHandling.Message("\t", newLine: false);
                topping.Print();
            }

            OutputHandling.Message($"Total Cost: {Cost.ToString("C", CultureInfo.CurrentCulture)}");
            Console.WriteLine();
        }
    }
}
