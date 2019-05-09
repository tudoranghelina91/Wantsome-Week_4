using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik_Defining_Classes.Classes;

namespace Telerik_Defining_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            GSMTest.PrintMobileDevices();
            Console.ReadKey();
            GSMHistoryTest.TestCalls();
            Console.ReadKey();
        }
    }
}
