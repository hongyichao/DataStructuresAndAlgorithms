using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class QuickSort
    {
        public void Sort(int[] items) 
        {
            Sort(items, 0, items.Length-1);
        }

        private void Sort(int[] array, int start, int end) 
        {
            if (start >= end) 
                return;

            var boundary = Partition(array, start, end);

            Sort(array, start, boundary - 1);
            Sort(array, boundary + 1, end);
        }


        private int Partition(int[] items, int start, int end) 
        {
            var pivot = items[end];
            var boundary = start -1;

            for (var i = start; i <= end; i++) 
                if (items[i] <= pivot)
                    Swap(items, i, ++boundary);

            return boundary;
        }

        private void Swap(int[] array, int index1, int index2) 
        { 
            var tmp = array[index1];
            array[index1] = array[index2];
            array[index2] = tmp;
        }
    }
}
