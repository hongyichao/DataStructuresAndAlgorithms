using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class BubbleSort
    {
        public int[] Sort(int[] items) 
        {
            bool isSorted;

            for (int i = 0; i < items.Length - 1; i++)
            {
                isSorted = true;

                for (int j = 0; j < items.Length - 1 - i; j++)
                {
                    if (items[j] > items[j + 1])
                    {
                        var tmp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = tmp;

                        isSorted = false;
                    }
                }

                if(isSorted)
                    return items;
            }

            return items;
        }
    }
}
