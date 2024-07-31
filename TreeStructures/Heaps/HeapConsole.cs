using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructures.Heaps
{
    internal class HeapConsole
    {
        public void Run()
        {
            var heap = new Heap(10);

            heap.Insert(10);
            heap.Insert(2);
            Console.WriteLine("---------------------");
            heap.Insert(15);
            heap.Insert(20);
            heap.Insert(30);
            Console.WriteLine("---------------------");
            heap.Insert(6);
            heap.Insert(7);

            Console.WriteLine("---------------------");

            Console.WriteLine("Node removed: " + heap.Remove());


            var numbers = new int[] { 5, 3, 10, 7, 8, 20 };

            var heap2 = new Heap(numbers.Length);

            foreach (var num in numbers) 
            {
                heap2.Insert(num);
            }

            for (int i = 0; i < numbers.Length; i++) 
            {
                numbers[i] = heap2.Remove();
            }

            Console.WriteLine(String.Join(", ", numbers));


            numbers = new int[] { 15, 3, 10, 7, 28, 20 };
            MaxHeap.Heapify(numbers);

            Console.WriteLine(String.Join(", ", numbers));


            
            Console.WriteLine("The Kth largest item: " + MaxHeap.GetKthLargestItem(numbers, 1));
            Console.WriteLine("The Kth largest item: " + MaxHeap.GetKthLargestItem(numbers, 2));
            Console.WriteLine("The Kth largest item: " + MaxHeap.GetKthLargestItem(numbers, 6));

            Console.WriteLine("Is max heap: " + MaxHeap.IsMaxHeap(numbers));
            Console.WriteLine("Is max heap: " + MaxHeap.IsMaxHeap(new int[] {10,20,30,15}));


            Console.WriteLine("-----Min Heap----------------");

            var minHeap = new MinHeap(100);

            minHeap.Insert(10, "10");
            minHeap.Insert(60, "60");
            minHeap.Insert(50, "50");
            minHeap.Insert(40, "40");
            minHeap.Insert(30, "30");
            minHeap.Insert(20, "20");
            minHeap.Insert(2, "2");


            var minList = new List<string>();

            while(!minHeap.IsEmpty())
                minList.Add(minHeap.Remove());

            Console.WriteLine(string.Join(", ", minList));


            var minPriorityQueue = new MinPriorityQueue();

            minPriorityQueue.Enqueue(10, "10");
            minPriorityQueue.Enqueue(20, "20");
            minPriorityQueue.Enqueue(5, "5");
            minPriorityQueue.Enqueue(30, "30");
            minPriorityQueue.Enqueue(4, "4");

            var numList = new List<string>();
            while (!minPriorityQueue.IsEmpty())
            {
                numList.Add(minPriorityQueue.Dequeue());
            }

            Console.WriteLine(string.Join(", ", numList));

            Console.WriteLine("done");
        }
    }
}

