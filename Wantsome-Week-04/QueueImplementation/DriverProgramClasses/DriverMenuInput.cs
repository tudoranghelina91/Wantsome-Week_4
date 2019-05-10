using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_04.Handlers;

namespace QueueImplementation.DriverProgramClasses
{
    public class DriverMenuInput
    {

        internal static void Select(Queue queue)
        {
            ConsoleKeyInfo cki = Console.ReadKey(true);

            switch (cki.Key)
            {
                case ConsoleKey.A:  // add to queue
                    {
                        DriverQueueOperations.Add(queue);
                        DriverMenuOutput.PrintMenu(queue);
                        break;
                    }

                case ConsoleKey.D:  // delete from queue
                    {
                        DriverQueueOperations.Remove(queue);
                        DriverMenuOutput.PrintMenu(queue);
                        break;
                    }

                case ConsoleKey.P:  // print queue
                    {
                        DriverQueueOperations.Print(queue);
                        DriverMenuOutput.PrintMenu(queue);
                        break;
                    }

                case ConsoleKey.E:  // exit program
                    break;

                default:
                    {
                        Select(queue);
                        break;
                    }
            }

        }
    }
}
