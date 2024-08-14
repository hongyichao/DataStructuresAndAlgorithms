using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class SelectionSort
    {
        public int[] Sort(int[] items)
        {
            bool isSorted;

            for (int i = 0; i < items.Length; i++)
            {
                var minIndex = i;
                for (int j = i+1; j < items.Length; j++)
                {
                    if (items[j] < items[i])
                        minIndex = j;
                }

                if (items[i] > items[minIndex])
                {
                    var tmp = items[i];
                    items[i] = items[minIndex];
                    items[minIndex] = tmp;
                }
            }

            return items;
        }
    }
}
