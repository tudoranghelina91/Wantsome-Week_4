using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_04.Handlers;

namespace QueueImplementation.DriverProgramClasses
{
    public class DriverMenuOutput
    {
        internal static void PrintMenu(Queue queue)
        {
            OutputHandling.Question("A - Add to queue, D - Delete from queue, P - Print Queue, E - Exit");
            DriverMenuInput.Select(queue);
        }
    }
}
