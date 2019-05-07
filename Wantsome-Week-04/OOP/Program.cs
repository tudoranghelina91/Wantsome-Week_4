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

            Human[] omusteni = new Human[]
            {
                new Human("Adam", "Primul Om", "Male", 1),
                new Human("Eva", "Prima Femeie", "Female", 1),
                new Human ("Cain", "Din Adam si Eva", "Male", 0),
                new Human ("Abel", "Din Adam si Eva", "Male", 0)
            };

            Human omusteanulsuprem = new Human("Gigi", "Calaul", "Mascul Feroce", 14);
            omusteanulsuprem.Print();
            Console.WriteLine("Inainte de setarea inaltimii: {0}m", omusteanulsuprem.Height);
            omusteanulsuprem.Height = 1.67M;

            Console.WriteLine("Dupa setarea inaltimii: {0}m", omusteanulsuprem.Height);

            foreach (Human omustean in omusteni)
            {
                omustean.Print();
            }

            Console.ReadKey();

            Point x = new Point(5, 7);
            Point y = new Point(12, 8);
            Point p = new Point(6, 9);

            Console.WriteLine(p.CalcDistance(x));

            Console.ReadKey();
        }
    }
}
