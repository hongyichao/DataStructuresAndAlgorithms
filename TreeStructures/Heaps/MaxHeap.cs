using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructures.Heaps
{
    internal class MaxHeap
    {
        // {10,20,15,4,6,26,28}
        public static void Heapify(int[] array) 
        {
            var lastParentIndex = array.Length / 2 - 1;

            for (var i = lastParentIndex; i >=0 ; i--)
            {
                Heapify(array, i);
            }
        }
        private static void Heapify(int[] array, int index) 
        {
            var maxIndex = index;

            var leftChildIndex = index * 2 + 1;            
            if (leftChildIndex < array.Length &&  array[leftChildIndex] > array[maxIndex]) 
                maxIndex = leftChildIndex;

            var rightChildIndex = index * 2 + 2;
            if (rightChildIndex < array.Length &&  array[rightChildIndex] > array[maxIndex])
                maxIndex = rightChildIndex;

            if (index == maxIndex)
                return;

            Swap(array, index, maxIndex);

            Heapify(array, maxIndex);
        }

        private static void Swap(int[] array, int firstIndex, int secondIndex) 
        {
            var tmp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = tmp;
        }

        public static int GetKthLargestItem(int[] array, int k) 
        {
            if (k < 1 || k > array.Length)
                throw new IndexOutOfRangeException();

            var heap = new Heap(array.Length);

            foreach (var n in array) 
                heap.Insert(n);

            for (int i =0; i < k - 1; i++) 
                heap.Remove();

            return heap.GetMaxItem();
        }
    }
}
