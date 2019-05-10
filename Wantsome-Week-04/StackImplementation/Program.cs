using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackImplementation.DriverProgramClasses;
using Wantsome_Week_04.Handlers;

namespace StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputHandling.Message("This is a driver program to test the functionality of the stack");
            Stack stack = new Stack();
            DriverMenuOutput.PrintMenu(stack);
        }
    }
}
