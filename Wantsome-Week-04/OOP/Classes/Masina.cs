using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    class Masina
    {
        public static int NrMasini = 0;

        public string Nume { get; set; }
        public Motor Motor { get; set; } = new Motor();

        public void Print()
        {
            Console.WriteLine($"{this.Motor.Capacitate}, {this.Nume}");
        }
    }
}
