using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_04.Handlers;

namespace StackImplementation.DriverProgramClasses
{
    public class DriverMenuOutput
    {
        internal static void PrintMenu(Stack stack)
        {
            OutputHandling.Question("A - Add to Stack, D - Delete from Stack, P - Print Stack, E - Exit");
            DriverMenuInput.Select(stack);
        }
    }
}
