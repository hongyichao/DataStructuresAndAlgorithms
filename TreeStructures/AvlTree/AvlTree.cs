using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructures.AvlTree
{
    public class AvlTree
    {
        private Node Root;

        public bool IsBalanced()
        {
            return IsBalanced(Root);
        }

        private bool IsBalanced(Node root)
        {
            if (root == null)
                return true;

            if (IsLeftHeavy(root))
                return false;

            if (IsRightHeavy(root))
                return false;

            return true;
        }

        public bool IsTreePerfect() 
        {
            return IsTreePerfect(Root);
        }

        private bool IsTreePerfect(Node root)
        {
            if (BalanceFactory(root) ==0) 
            {
                if(root != null)
                    return IsTreePerfect(root.LeftChild) && IsTreePerfect(root.RightChild);
                return true;
            }

            return false;
        }




        public void Insert(int value) 
        {            
            Root = Insert(Root, value);
        }

        private Node Insert(Node current, int value) 
        {
            if (current == null)
                return new Node(value);
            if (value <= current.Value)
            {
                current.LeftChild = Insert(current.LeftChild, value);
            }
            else
            {
                current.RightChild = Insert(current.RightChild, value);
            }

            SetNodeHeight(current);

            return balanceTheTree(current);
        }

        private Node balanceTheTree(Node current) 
        {
            if (IsLeftHeavy(current)) 
            {
                if (BalanceFactory(current.LeftChild) < 0) 
                    current.LeftChild = RotateLeft(current.LeftChild);
                return RotateRight(current);
            }

            if (IsRightHeavy(current)) 
            {
                if (BalanceFactory(current.RightChild) > 0)
                    current.RightChild = RotateRight(current.RightChild);
                return RotateLeft(current);
            }

            return current;
        }

        private Node RotateLeft(Node current) 
        {
            var newRoot = current.RightChild;

            current.RightChild = newRoot.LeftChild;
            newRoot.LeftChild = current;

            SetNodeHeight(current);
            SetNodeHeight(newRoot);

            return newRoot;
        }

        private Node RotateRight(Node current) 
        {
            var newRoot = current.LeftChild;

            current.LeftChild = newRoot.RightChild;
            newRoot.RightChild = current;

            SetNodeHeight(current);
            SetNodeHeight(newRoot);

            return newRoot;
        }

        private void SetNodeHeight(Node node) 
        {
            node.Height = Math.Max(Height(node.LeftChild), Height(node.RightChild)) + 1;
        }


        private bool IsLeftHeavy(Node current) 
        {
            return BalanceFactory(current) > 1;
        }

        private bool IsRightHeavy(Node current) 
        {
            return BalanceFactory(current) < -1;
        }

        private int BalanceFactory(Node current) 
        {
            return (current == null) ? 0 : Height(current.LeftChild) - Height(current.RightChild);
        }

        private int Height(Node current) 
        {
            return (current == null) ? -1 : current.Height;
        }

        private bool IsLeafNode(Node current) 
        {
            return current.LeftChild == null && current.RightChild == null;
        }
        
    }

    public class Node
    {
        public int Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        public int Height { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}
