using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_04.Handlers;

namespace StackImplementation.DriverProgramClasses
{
    public class DriverMenuInput
    {

        internal static void Select(Stack stack)
        {
            ConsoleKeyInfo cki = Console.ReadKey(true);

            switch (cki.Key)
            {
                case ConsoleKey.A:  // add to stack
                    {
                        DriverStackOperations.Add(stack);
                        DriverMenuOutput.PrintMenu(stack);
                        break;
                    }

                case ConsoleKey.D:  // delete from stack
                    {
                        DriverStackOperations.Remove(stack);
                        DriverMenuOutput.PrintMenu(stack);
                        break;
                    }

                case ConsoleKey.P:  // print stack
                    {
                        DriverStackOperations.Print(stack);
                        DriverMenuOutput.PrintMenu(stack);
                        break;
                    }

                case ConsoleKey.E:  // exit program
                    break;

                default:
                    {
                        Select(stack);
                        break;
                    }
            }

        }
    }
}
