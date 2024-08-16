using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class CountingSort
    {
        public void Sort(int[] array, int max) 
        {
            var countArray = new int[max + 1];

            foreach(var i in array)
                countArray[i]++;

            var k = 0;

            for (int i = 0; i < countArray.Length; i++) 
            {
                for (var j = 0; j < countArray[i]; j++)
                    array[k++] = i;

            }
        }
    }
}
