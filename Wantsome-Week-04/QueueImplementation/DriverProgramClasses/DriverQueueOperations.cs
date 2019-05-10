using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_04.Handlers;

namespace QueueImplementation.DriverProgramClasses
{
    public class DriverQueueOperations
    {
        internal static void Add(Queue queue)
        {
            queue.Enqueue(InputHandling.ReadValue("Value to add: "));
            OutputHandling.Message($"{queue.First.Value} has been added to the queue...", ConsoleColor.Green);
        }
        internal static void Remove(Queue queue)
        {
            try
            {
                queue.Dequeue();
                OutputHandling.Message($"{queue.First.Value} has been removed from the queue...", ConsoleColor.Red);
            }

            catch
            {
                OutputHandling.Message($"The queue is empty", ConsoleColor.Red);
            }
        }

        internal static void Print(Queue queue)
        {
            if (queue.First != null)
            {
                OutputHandling.Message("Elements in queue: ", newLine: false);
                queue.Print();
            }

            else
            {
                OutputHandling.Message("There are no elements in the current list!", consoleColor: ConsoleColor.Magenta);
            }
        }
    }
}
