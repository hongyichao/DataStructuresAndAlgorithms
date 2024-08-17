using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class BucketSort
    {
        public void Sort(int[] array, int numberOfBuckets) 
        {
            var i = 0; 
            foreach ( var bucket in CreateBuckets(array, numberOfBuckets))
            {
                bucket.Sort();

                foreach(var item in bucket)
                    array[i++] = item;
            }
        }

        private List<List<int>> CreateBuckets(int[] array, int numberOfBuckets) 
        {
            var buckets = new List<List<int>>();

            for(int i=0; i<numberOfBuckets; i++)
                buckets.Add(new List<int>());

            foreach (var i in array)
                buckets[i / numberOfBuckets].Add(i);

            return buckets;
        }

    }
}
