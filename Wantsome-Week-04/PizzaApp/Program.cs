using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaApp.Classes;

namespace PizzaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // create pizza base objects
            PizzaBase regular = new PizzaBase("Regular", 1);
            PizzaBase thick = new PizzaBase("Thick", 1);
            PizzaBase italian = new PizzaBase("Italian", 1);
            
            // instantiate pizza objects
            Pizza pizza1 = new Pizza("Magiunata", thick);
            Pizza pizza2 = new Pizza("Manelista", regular);
            Pizza pizza3 = new Pizza("Campeneasca", italian);

            // Pizza 1 toppings
            pizza1.AddTopping("Magiun", 0.23m);
            pizza1.AddTopping("SALAMI", 1m);
            pizza1.AddTopping("PASTRAMI", 1.2m);
            pizza1.AddTopping("Tomatoes", 0.5m);
            pizza1.AddTopping("Olives", 1m);
            // total cost
            pizza1.CalculateTotalCost();

            // Pizza 2 toppings
            pizza2.AddTopping("SALAMI", 0.24m);
            pizza2.AddTopping("Olives Value!", 999999m);
            pizza2.AddTopping("Cheese Enemies", 0m);
            // total cost
            pizza2.CalculateTotalCost();

            // Pizza 3 toppings
            pizza3.AddTopping("SALAMI", 3);
            pizza3.AddTopping("PASTRAMI", 2.13m);
            pizza3.AddTopping("Onions", 0.25m);
            pizza3.AddTopping("Tomatoes", 0.16m);
            // total cost
            pizza3.CalculateTotalCost();

            pizza1.Print();
            pizza2.Print();
            pizza3.Print();
            Console.ReadKey();
        }
    }
}
