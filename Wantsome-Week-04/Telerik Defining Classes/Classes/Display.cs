using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_04.Handlers;

namespace Telerik_Defining_Classes.Classes
{
    public class Display
    {
        public decimal Size { get; set; }
        public int NumberOfColors { get; set; }

        public Display(decimal size, int numberOfColors)
        {
            Size = size;
            NumberOfColors = numberOfColors;
        }

        public Display()
        {
            // DEFAULT CONSTRUCTOR
        }

        public void Print()
        {
            OutputHandling.Message($"Size: {Size}\"");
            OutputHandling.Message($"Colors: {NumberOfColors}M");
        }
    }
}
