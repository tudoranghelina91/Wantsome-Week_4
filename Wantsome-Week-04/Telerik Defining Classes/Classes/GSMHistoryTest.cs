using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik_Defining_Classes.Classes
{
    public class GSMHistoryTest
    {

        public static void TestCalls()
        {
            GSM myGSM = new GSM();
            myGSM.AddCall("0232121212", 10.23m);
            myGSM.AddCall("07APACALDA", 2.17m);
            myGSM.AddCall("07APACALDA", 2.19m);
            myGSM.AddCall("07APACALDA", 23.55m);
            myGSM.AddCall("0175123456", 6.99m);
            
            foreach (Call call in myGSM.CallHistory)
            {
                call.Print();
                Console.WriteLine();
            }
            Console.WriteLine();
            // Call Price before removal
            Console.WriteLine($"Total Call price: {myGSM.CallPrice(0.37m)}");
            Console.WriteLine();
            // Removing longest call
            Console.WriteLine("REMOVING THE LONGEST CALL");
            myGSM.RemoveCall();
            // Price after removal
            Console.WriteLine($"Call price: {myGSM.CallPrice(0.37m)}");
            // print call history

            foreach (Call call in myGSM.CallHistory)
            {
                call.Print();
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
