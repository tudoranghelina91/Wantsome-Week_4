using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_04.Handlers;

namespace StackImplementation.DriverProgramClasses
{
    public class DriverStackOperations
    {
        internal static void Add(Stack stack)
        {
            stack.Push(InputHandling.ReadValue("Value to add: "));
            OutputHandling.Message($"{stack.Top.Value} has been added to the top of the stack...", ConsoleColor.Green);
        }
        internal static void Remove(Stack stack)
        {
            try
            {
                OutputHandling.Message($"{stack.Top.Value} has been removed from the top of the stack...", ConsoleColor.Red);
                stack.Pop();
            }

            catch
            {
                OutputHandling.Message($"The stack is empty", ConsoleColor.Red);
            }
        }

        internal static void Print(Stack stack)
        {
            if (stack.Top != null)
            {
                OutputHandling.Message("Elements in stack: ", newLine: false);
                stack.Print();
            }

            else
            {
                OutputHandling.Message("There are no elements in the current stack!", consoleColor: ConsoleColor.Magenta);
            }
        }
    }
}
