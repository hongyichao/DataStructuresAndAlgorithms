using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructures.Heaps
{
    public class MinPriorityQueue
    {
        MinHeap heap = new MinHeap(100);

        public void Enqueue(int key, string value) 
        {
            heap.Insert(key, value);
        }

        public string Dequeue() 
        {
            return heap.Remove();
        }

        public bool IsEmpty() 
        {
            return heap.IsEmpty();
        }
    }
}
