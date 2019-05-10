using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    internal class StackItem
    {
        internal int Value { get; set; }
        internal StackItem next = null;
    }
}
