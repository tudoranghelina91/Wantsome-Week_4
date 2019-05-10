using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome_Week_04.Handlers;

namespace StackImplementation
{
    internal class Stack
    {
        internal void Push(int value)
        {
            StackItem newStackItem = new StackItem();
            newStackItem.Value = value;
            newStackItem.next = Top;
            Top = newStackItem;
        }

        internal void Pop()
        {
            Top = Top.next;
        }

        internal void Print()
        {
            StackItem currentStackItem = Top;

            while (currentStackItem != null)
            {
                Console.Write($"{currentStackItem.Value} ");
                currentStackItem = currentStackItem.next;
            }

            Console.WriteLine();
        }

        internal StackItem Top = null;
    }
}
