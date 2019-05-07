using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    public class Dog
    {
        public string Name;
        public string Owner;
        public string Breed;
        public int Age;

        internal double PI = 3.14;

        public void Bark()
        {
            Console.WriteLine("Woof Woof!!!");
        }

        public void PrintName()
        {
            Console.WriteLine(this.Name);
        }
    }
}
