using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class MergeSort
    {
        public void Sort(int[] items) 
        {
            if (items.Length < 2)
                return;

            var middle = items.Length / 2;

            var left = new int[middle];
            for (int i = 0; i < middle; i++) 
            {
                left[i] = items[i];
            }

            var right = new int[items.Length - middle];
            for (int i = middle; i < items.Length; i++) 
            {
                right[i-middle] = items[i];
            }

            Sort(left);
            Sort(right);

            Merge(left, right, items);
        }


        private void Merge(int[] left, int[] right, int[] items) 
        {
            int i=0, j=0, k=0;

            while (i < left.Length && j < right.Length) 
            {
                if (left[i] <= right[j])
                    items[k++] = left[i++];
                else
                    items[k++] = right[j++];
            }

            while(i< left.Length)
                items[k++] = left[i++];

            while(j<right.Length)
                items[k++] = right[j++];    
        }
    }
}
