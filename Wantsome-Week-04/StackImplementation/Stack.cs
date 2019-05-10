using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    internal class Stack
    {

        internal void Push(int value)
        {

        }

        internal void Pop()
        {

        }

        internal void Print()
        {
            StackItem currentStackItem = First;
            while (currentStackItem != null)
            {
                Console.WriteLine(currentStackItem.Value);
                currentStackItem = currentStackItem.next;
            }
        }

        internal StackItem First = null;
    }
}
