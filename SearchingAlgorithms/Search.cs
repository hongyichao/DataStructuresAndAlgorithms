using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms
{
    public class Search
    {

        public int LinearSearch(int[] array, int item) 
        {
            for (int i=0; i< array.Length; i++) 
            {
                if(array[i]==item)
                    return i;
            }

            return -1;
        }

        public int BinarySearchRec(int[] array, int target) 
        {
            return BinarySearchRec(array, target, 0, array.Length - 1);
        }

        private int BinarySearchRec(int[] array, int target, int left, int right) 
        {
            if (left > right)
                return -1;

            int middle = (left + right) / 2;

            if(target == array[middle])
                return middle;

            if (target < array[middle]) 
                return BinarySearchRec(array, target, left, middle - 1);

            return BinarySearchRec(array, target, middle + 1, right);
        }

        public int BinarySearch(int[] array, int target) 
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right) 
            {
                var middle = (left + right) / 2;

                if(target == array[middle])
                    return middle;

                if(target < array[middle])
                    right = middle-1;
                else
                    left = middle+1;
            }

            return -1;
        }

        public int TernarySearch(int[] array, int target) 
        {
            return TernarySearch(array, target, 0, array.Length - 1);
        }

        private int TernarySearch(int[] array, int target, int left, int right) 
        {
            if(left>right)
                return -1;

            var partitionSize = array.Length / 3;
            var mid1 = left + partitionSize; 
            var mid2 = right - partitionSize;

            if(target == array[mid1])
                return mid1;

            if (target < array[mid1])
                return TernarySearch(array, target, left, mid1 - 1);

            if(target == array[mid2])
                return mid2;

            if (target > array[mid2])
                return TernarySearch(array, target, mid2+1, right);

            return TernarySearch(array, target, mid1 + 1, mid2 - 1);
        }

        public int JumpSearch(int[] array, int target) 
        {
            var blockSize= (int)Math.Sqrt(array.Length);
            int start = 0;
            int next = blockSize;

            while (start < array.Length && array[next - 1] < target) 
            {
                start = next;
                next += blockSize;
                if(next > array.Length)
                    next = array.Length;
            }

            for (int i = start; i < next; i++) 
            {
                if (array[i] == target)
                    return i;
            }

            return -1;
        }

        public int ExponentialSearch(int[] array, int target) 
        {
            int bound = 1;
            int previousBound = 1;

            while (bound < array.Length && target > array[bound]) 
                bound *= 2;

            int left = bound / 2;
            int right = Math.Min(bound, array.Length - 1);

            return BinarySearchRec(array, target, left, right);
        }
    }
}
