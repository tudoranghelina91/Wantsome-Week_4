using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik_Defining_Classes.Classes
{
    public class GSMTest
    {
        static Battery battery1 = new Battery("Samsung", 123.25m, 29.44m);
        static Battery battery2 = new Battery("Lenovo", 143.2m, 56.3m);

        static Display display1 = new Display(12.3m, 123);
        static Display display2 = new Display(11.2m, 331);

        static GSM device1 = new GSM(battery1, display1);
        static GSM device2 = new GSM(battery2, display2);
        static GSM[] gsmArr = new GSM[] { device1, device2, GSM.Iphone };

        public static void PrintMobileDevices()
        {
            foreach (GSM device in gsmArr)
            {
                device.Print();
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
