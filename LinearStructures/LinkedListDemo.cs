using LinearStructures.LinkedList;

namespace LinearStructures
{
    internal class LinkedListDemo
    {
        public static void Run()
        {
            var linkedList = new MyLinkedList();

            linkedList.AddFirst(4);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);

            linkedList.PrintNodes();

            linkedList.AddLast(5);
            linkedList.AddLast(6);
            linkedList.PrintNodes();

            Console.WriteLine("Index=>" + linkedList.IndexOf(4));

            Console.WriteLine($"Contains=> {linkedList.Contains(3)}");

            linkedList.DeleteFirst();
            linkedList.PrintNodes();

            linkedList.DeleteLast();
            linkedList.PrintNodes();

            Console.WriteLine($"Size=> {linkedList.GetSize()}");

            var myArray = linkedList.ToArray();

            foreach (var i in myArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            var reversedLinkedList = linkedList.Reverse();
            reversedLinkedList.PrintNodes();

            var kthNodeFromEnd = linkedList.GetKthNodeFromTheEnd(2);
            Console.WriteLine(kthNodeFromEnd.ToString());
            kthNodeFromEnd = linkedList.GetKthNodeFromTheEnd(1);
            Console.WriteLine(kthNodeFromEnd.ToString());
            kthNodeFromEnd = linkedList.GetKthNodeFromTheEnd(3);
            Console.WriteLine(kthNodeFromEnd.ToString());
            kthNodeFromEnd = linkedList.GetKthNodeFromTheEnd(4);
            Console.WriteLine(kthNodeFromEnd.ToString());
            kthNodeFromEnd = linkedList.GetKthNodeFromTheEnd(5);
            Console.WriteLine(kthNodeFromEnd.ToString());

            linkedList.AddLast(8);
            linkedList.AddLast(9);
            linkedList.AddLast(7);
            linkedList.PrintNodes();
            var middle = linkedList.GetTheMiddleOfTheList();
            Console.WriteLine(middle.ToString());
        }
    }
}

