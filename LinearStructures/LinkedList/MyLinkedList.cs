
using System.ComponentModel.DataAnnotations;

namespace LinearStructures.LinkedList
{
    internal class MyLinkedList
    {
        private Node? first;
        private Node? last;
        private int length;

        public MyLinkedList() 
        {
            first = null;
            last = null;
            length = 0;
        }

        public int GetTheMiddleOfTheList() 
        {
            if (IsEmpty())
                return -1;

            if (first == last) 
            {
                return first.value;
            }

            var dest = first;
            var target = first;

            int count = 1;

            while (dest != last) 
            {
                dest = dest.next;
                count++;
            }

            var middlePoint = (int) (count / 2) +1;

            for (int i = 1; i < middlePoint; i++)
                target = target.next;

            return target.value;
        }

        public int GetKthNodeFromTheEnd(int k)
        {
            if(k<=0 || k > length || IsEmpty())
                return -1;
            Node target = first;
            Node destination = first;

            var index = 0;
            while (destination.next != null) 
            {
                destination = destination.next;
                index++;
                if (index >= k) 
                {
                    target = target.next;
                }
            }

            return target.value;
        }

        public void AddFirst(int number) 
        {
            var newNode = new Node(number);

            if (IsEmpty())
            {
                first = newNode;
                last = newNode;
            }
            else {
                newNode.next = first;
                first = newNode;
            }

            length++;
        }

        public void AddLast(int number)
        {
            var newNode = new Node(number);

            if (IsEmpty())
            {
                last = newNode;
                first = newNode;
            }
            else 
            {
                if (last != null)
                    last.next = newNode;
                last = newNode;
            }
            length++;
        }

        private bool IsEmpty()         
        { 
            return first == null || last == null;
        }

        public int IndexOf(int number) 
        {
            int index = 0;
            var current = first;
            while (current != null) 
            {
                if(current.value == number)
                    return index;
                current = current.next;
                index++;
            }
            return -1;
        }

        public bool Contains(int number) 
        {
            return IndexOf(number) >= 0;
        }

        public void DeleteFirst() 
        {
            if (IsEmpty())
                return;

            if (first == last)
            {
                first = null;
                last = null;
            }
            else 
            {
                var next = first.next;
                first.next = null;
                first = next;
            }
            length--;
        }

        public int GetSize()         
        { 
            return length;
        }

        public void DeleteLast()
        {
            if (IsEmpty())
                return;

            if (first == last)
            {
                first = null;
                last = null;
            }
            else 
            {
                var current = first;
                while (current != null)
                {
                    if (current.next == last)
                    {
                        current.next = null;
                        last = current;
                        break;
                    }
                    else
                        current = current.next;
                }
            }
            length--;
        }

        public int[] ToArray() 
        {
            var array = new int[length];

            var current = first;
            var count = 0;
            while (current != null) 
            {
                array[count] = current.value;

                current = current.next;
                count++;
            }

            return array;
        }

        public MyLinkedList Reverse() 
        {
            MyLinkedList reversedLinkedList = new MyLinkedList();

            var current = first;
            while (current != null) 
            {
                reversedLinkedList.AddFirst(current.value);
                current = current.next;
            }

            return reversedLinkedList;

        }

        public void PrintNodes() 
        {
            var currentNode = first;            
            while (currentNode != null) 
            {
                Console.Write(currentNode.ToString() + " ");
                currentNode = currentNode.next;
            }

            Console.WriteLine();
        }
    }
}
