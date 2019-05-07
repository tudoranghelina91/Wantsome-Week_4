using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Classes;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog1 = new Dog();

            Dog myDog2 = new Dog();
            myDog1.Age = 5;
            myDog1.Breed = "Stray";
            myDog1.Owner = "Magiun Stavarache";
            myDog1.Name = "Gealau";

            myDog2.Name = "Maricica";
            myDog2.Age = 4;
            myDog2.Breed = "Saint Bernard";
            myDog2.Owner = "Larisa Capdeguma";

            Console.WriteLine(myDog1.Name);
            Console.ReadKey();

            Human myHuman = new Human("Nicolae", "Botgros", "Male", 27);
            Human myHuman2 = new Human("Dumitru", "Magiun", "Male", 32);
            myHuman.Print();
            myHuman2.Print();
            Console.ReadKey();
        }
    }
}
