using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP2.StaffMembers;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Gelu", "Botgros");
            Programmer programmer = new Programmer("Gigi", "Hackeru'");

            manager.Department = "Acquisitios";
            programmer.Technology = ".NET";

            manager.Print();
            programmer.Print();
            Console.ReadKey();
        }
    }
}
