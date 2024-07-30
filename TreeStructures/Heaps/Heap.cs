using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeStructures.BinaryTree;

namespace TreeStructures.Heaps
{
    public class Heap
    {
        private int[] Nodes;
        private int NodeCount;


        public Heap(int size)
        {
            Nodes = new int[size];
            NodeCount = 0;
        }

        public int Remove()
        {
            if (IsEmpty()) 
            {
                throw new ApplicationException("The heap is empty");
            }

            var root = Nodes[0];

            Nodes[0] = Nodes[--NodeCount];

            BubbleDown();

            return root;
        }

        public bool IsEmpty() 
        {
            return Nodes.Length == 0;
        }

        private void BubbleDown() 
        {
            var index = 0;
            while (index <= NodeCount && !IsValidParent(index))
            {
                var maxChildIndex = MaxChildIndex(index);

                Swap(index, maxChildIndex);

                index = maxChildIndex;
            }
        }

        private bool IsValidParent(int index) 
        {
            if (!HasLeftChild(index))
                return true;

            var isValid = Nodes[index] >= LeftChild(index);

            if (HasRightChild(index))
                isValid = isValid && Nodes[index] >= RightChild(index);

            return isValid;
        }

        private bool HasLeftChild(int index) 
        {
            return GetLeftChildIndex(index) <= NodeCount;
        }

        private bool HasRightChild(int index) 
        {
            return GetRightchildIndex(index) <= NodeCount;
        }

        private int MaxChildIndex(int index) 
        {
            if (!HasLeftChild(index))
                return index;

            if(!HasRightChild(index))
                return GetLeftChildIndex(index);

            return LeftChild(index)> RightChild(index) ? GetLeftChildIndex(index): GetRightchildIndex(index);
        }

        public int LeftChild(int index) 
        {
            return Nodes[GetLeftChildIndex(index)];
        }

        public int RightChild(int index)
        {
            return Nodes[GetRightchildIndex(index)];
        }


        public int GetLeftChildIndex(int index)
        {
            return (index * 2) + 1;
        }

        public int GetRightchildIndex(int index) 
        {
            return (index * 2) + 2;
        }


        public bool IsFull() 
        {
            return NodeCount == Nodes.Length;
        }

        public void Insert(int value) 
        {
            if (IsFull())
                throw new IndexOutOfRangeException();

            Nodes[NodeCount++] = value;
            BubbleUp();
        }

        public void BubbleUp() 
        {
            var index = NodeCount - 1;
            while (index > 0 && Nodes[index] > Nodes[GetParentIndex(index)])
            {
                Swap(index, GetParentIndex(index));
                index = GetParentIndex(index);
            }
        }

        public int GetParentIndex(int index) 
        {
            return (index - 1) / 2;
        }

        public void Swap(int first, int second) 
        {
            var tmp = Nodes[first];
            Nodes[first] = Nodes[second];
            Nodes[second] = tmp;
        }

    }
}
