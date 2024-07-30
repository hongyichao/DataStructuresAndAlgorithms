using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructures.Heaps
{
    internal class PriorityQueueHeap
    {
        private Heap heap = new Heap(100);

        public void Enqueue(int item) 
        {
            heap.Insert(item);
        }

        public int Dequeue() 
        {
            return heap.Remove();
        }

        public bool IsEmpty() 
        {
            return heap.IsEmpty();
        }

    }
}
