using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    internal class Queue
    {
        internal void Enqueue(int value)
        {
            QueueItem newItem = new QueueItem();
            newItem.Value = value;

            if (First == null)
            {
                First = newItem;
            }

            else
            {
                newItem.next = First;
                First = newItem;
            }
        }

        internal void Dequeue()
        {
            if (First != null)
            {
                First = First.next;
            }
        }

        internal void Print()
        {
            QueueItem traverse = First;
            while (traverse != null)
            {
                Console.Write($"{traverse.Value} ");
                traverse = traverse.next;
            }

            Console.WriteLine();
        }

        internal QueueItem First = null;
    }
}
