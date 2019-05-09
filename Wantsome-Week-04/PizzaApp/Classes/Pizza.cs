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
        decimal totalCost = 0;
        string TotalCost = "";


        public Pizza(string name, PizzaBase pizzaBase)
        {
            Base = pizzaBase;
            PizzaName = name;
        }

        public void AddTopping(string toppingName, decimal cost)
        {
            PizzaTopping newTopping = new PizzaTopping(toppingName, cost);
            Toppings.Add(newTopping);
        }

        public void CalculateTotalCost()
        {
            foreach (PizzaTopping topping in Toppings)
            {
                totalCost += topping.Cost;
            }

            totalCost += Base.Cost;
            TotalCost = totalCost.ToString("C2", CultureInfo.CurrentCulture);
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

            OutputHandling.Message($"Total Cost: {TotalCost}");
            Console.WriteLine();
        }
    }
}
