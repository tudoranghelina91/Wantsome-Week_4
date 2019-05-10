using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    internal class QueueItem
    {
        internal int Value { get; set; }
        internal QueueItem next = null;
    }
}
