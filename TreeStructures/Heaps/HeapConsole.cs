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

            Console.WriteLine("done");
        }
    }
}
