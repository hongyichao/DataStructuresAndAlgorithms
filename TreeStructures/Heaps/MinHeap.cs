using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructures.Heaps
{
    public class MinHeap
    {
        private HeapNode[] items;
        private int size;

        public MinHeap(int size) 
        {
            items = new HeapNode[size];
        }

        public string Remove() 
        {
            if(IsEmpty())
                throw new IndexOutOfRangeException();

            var root = items[0].Value;
            items[0] = items[--size];

            BubbleDown();

            return root;

        }

        public void BubbleDown() 
        {
            var index = 0;

            while (index <= size && !IsValidParent(index)) 
            {
                var smallerIndex = smallerChildIndex(index);

                Swap(index, smallerIndex);
                index = smallerIndex;
            }
        }

        private int smallerChildIndex(int index) 
        {
            if (!HasLeftChild(index))
                return index;

            if(!HasRightChild(index))
                return LeftChildIndex(index);

            return (LeftChild(index).Key < RightChild(index).Key) ? LeftChildIndex(index) : RightChildIndex(index);
        }

        private HeapNode LeftChild(int index) 
        {
            return items[LeftChildIndex(index)];
        }

        private HeapNode RightChild(int index)
        {
            return items[RightChildIndex(index)];
        }

        private bool HasLeftChild(int index) 
        {
            return LeftChildIndex(index) <=size;
        }

        private bool HasRightChild(int index)
        {
            return RightChildIndex(index) <= size;
        }

        private bool IsValidParent(int index) 
        {
            if(!HasLeftChild(index))
                return true;

            var isValid = items[index].Key <= LeftChild(index).Key;

            if(HasRightChild(index))
                isValid= isValid && items[index].Key <= RightChild(index).Key;

            return isValid;
        }


        public bool IsEmpty() 
        {
            return size == 0;
        }

        private int LeftChildIndex(int index)
        {
            return index * 2 + 1;
        }

        private int RightChildIndex(int index)
        {
            return index * 2 + 2;
        }


        public void Insert(int key, string value) 
        {
            if (IsFull())
                throw new IndexOutOfRangeException();

            items[size++] = new HeapNode(key, value);

            BubbleUp();
        }

        

        private void BubbleUp() 
        {
            var index = size - 1;
            
            while (index>0 && items[index].Key < items[ParentIndex(index)].Key) 
            {
                Swap(index, ParentIndex(index));
                index = ParentIndex(index);
            }
        }

        private void Swap(int first, int second) 
        {
            var tmp = items[first]; 
            items[first] = items[second]; 
            items[second] = tmp;
        }

        private int ParentIndex(int index) 
        {
            return (index - 1) / 2;
        }

        public bool IsFull() 
        {
            return size == items.Length;
        }

    }

    public class HeapNode 
    {
        public int Key;
        public string Value;

        public HeapNode(int key, string value) {
            this.Key = key;
            this.Value = value; 
        }
    }
}
