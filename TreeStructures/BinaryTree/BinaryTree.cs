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
