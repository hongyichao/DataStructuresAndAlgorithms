using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TreeStructures.BinaryTree
{
    public class BinaryTree
    {
        private Node root;

        public void PrintByLevelOrderTraverse() 
        {
            for (int i = 0; i < Height(); i++) 
            {
                var list = GetNodeAtGivenDistance(i);

                foreach (var v in list) 
                {
                    Console.WriteLine(v);
                }
            }
        }


        public void PrintByPreOrderTraverse() 
        {
            //root, left, right
            TraversePreOrder(root);
        }

        private void TraversePreOrder(Node current) 
        {
            if (current == null)
                return;
            Console.WriteLine(current.Value);
            TraversePreOrder(current.LeftChild);
            TraversePreOrder(current.RightChild);
        }


        public void PrintByInOrderTraverse(bool isInDescendingOrder) 
        {
            if (!isInDescendingOrder)
            {
                //Left, Root, Right
                TraverseInAscendingOrder(root);
            }
            else 
            {
                //Right, Root, Left
                TraverseInDescendingOrder(root);
            }
        }

        private void TraverseInAscendingOrder(Node current) 
        {
            if(current==null)
                return;

            TraverseInAscendingOrder(current.LeftChild);
            Console.WriteLine(current.Value);
            TraverseInAscendingOrder(current.RightChild);
        }

        private void TraverseInDescendingOrder(Node current)
        {
            if (current == null)
                return;

            TraverseInDescendingOrder(current.RightChild);            
            Console.WriteLine(current.Value);
            TraverseInDescendingOrder(current.LeftChild);
        }


        public void PrintByPostOrderTraverse() 
        {
            //Left, Right, Root
            TraversePostOrder(root);
        }

        private void TraversePostOrder(Node current) 
        { 
            if(current == null)
                return;

            TraversePostOrder(current.LeftChild);
            TraversePostOrder(current.RightChild);
            Console.WriteLine(current.Value);
        }


        public int Min() 
        {
            return Min(root);
        }

        private int Min(Node current) 
        {
            if (current == null) 
                return -1;

            if (current.LeftChild != null)
                return Min(current.LeftChild);

            return current.Value;
        }

        public int Height() 
        {
            return Height(root);
        }

        private int Height(Node current) 
        {
            if(current == null)
                return -1;

            if (current.LeftChild == null && current.RightChild == null)
                return 0;

            return 1 + Math.Max(Height(current.LeftChild), Height(current.RightChild));
        }

        public bool Equal(BinaryTree other) 
        {
            if(other  == null)
                return false;

            return Equal(this.root, other.root);
        }

        private bool Equal(Node first, Node second) 
        {
            if (first == null && second == null) 
                return true;

            if(first!=null && second !=null)
                return first.Value == second.Value
                && Equal(first.LeftChild, second.LeftChild)
                && Equal(first.RightChild, second.RightChild);

            return false;

        }

        public void SwapRoot() 
        {
            if (root != null) 
            {
                var tmp = root.LeftChild;
                root.LeftChild = root.RightChild; 
                root.RightChild = tmp;
            }
        }

        public bool Validate() 
        {
            return Validate(root, int.MinValue, int.MaxValue);
        }

        private bool Validate(Node current, int from, int to) 
        {
            if (current == null)
                return true;

            if (IsLeafNode(current))
            {
                if((current.Value >= from) && (current.Value< to))
                    return true;

                return false;
            }

            return Validate(current.LeftChild, from, current.Value) && Validate(current.RightChild, current.Value, to);

        }

        public List<int> GetNodeAtGivenDistance(int distance) 
        {
            var  nodeValueList = new List<int>();

            GetNodeAtGivenDistance(root, distance, nodeValueList);

            return nodeValueList;
        }



        private void GetNodeAtGivenDistance(Node current, int distance, List<int> nodeValueList) 
        {
            if (current == null) 
            {   
                return;
            }

            if (distance == 0)
            {
                nodeValueList.Add(current.Value);
                return;
            }

            distance--;

            GetNodeAtGivenDistance(current.LeftChild, distance, nodeValueList);
            GetNodeAtGivenDistance(current.RightChild, distance, nodeValueList);
        }

        


        public bool IsLeafNode(Node current) 
        {
            return current.LeftChild == null && current.RightChild == null;
        }

        public bool Find(int value) 
        {
            var current = root;

            while (current != null) 
            {
                if (current.Value == value)
                    return true;
                else {
                    if (value > current.Value)
                    {
                        current = current.RightChild;
                    }
                    else 
                    {
                        current = current.LeftChild;
                    }
                }
            }
            return false;
        }

        public void Insert(int value) 
        {
            var newNode = new Node(value);

            if (root == null)
            {
                root = newNode;
                return;
            }
            else 
            {
                var current = root;

                while (true) 
                {
                    if (value < current.Value) 
                    {
                        if (current.LeftChild == null) 
                        {
                            current.LeftChild = newNode;
                            break;
                        }
                        current = current.LeftChild;
                    }
                    else
                    {
                        if (current.RightChild == null) 
                        {
                            current.RightChild = newNode; 
                            break;
                        }
                        current = current.RightChild;
                    }
                }
            }

        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        public Node(int value)
        {
            Value = value;
        }


        public override string ToString()
        {
            return "Node value: " + Value;
        }
    }
}
