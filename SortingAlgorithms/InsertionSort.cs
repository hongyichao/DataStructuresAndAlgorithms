using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class InsertionSort
    {
        public int[] Sort(int[] items) 
        {
            for (int i = 1; i < items.Length; i++) 
            {
                var currentIndex = i;
                var currentValue = items[i];
                for (int j = i - 1; j >= 0 ; j--) 
                {
                    if (currentValue < items[j])
                    { 
                        items[currentIndex] = items[j];
                        currentIndex--;
                    }
                }

                items[currentIndex] = currentValue;
            }

            return items;
        }
    }
}
