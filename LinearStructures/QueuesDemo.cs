using LinearStructures.Queues;

namespace LinearStructures
{
    public class QueuesDemo
    {
        public static void Run()
        {
            MyQueue myQueue = new MyQueue();

            myQueue.Add(1);
            myQueue.Add(2);
            myQueue.Add(3);
            myQueue.Add(4);
            myQueue.Add(5);
            myQueue.Add(6);
            myQueue.Add(7);
            myQueue.Add(8);
            myQueue.Add(9);

            foreach (var i in myQueue.Reverse())
            {
                Console.Write(i);
            }
            Console.WriteLine();

            var reverseByStack = myQueue.ReverseWithStack();
            foreach (var i in reverseByStack)
            {
                Console.Write(i);
            }
            MyQueue myQueue2 = new MyQueue();
            myQueue2.Add(1);
            myQueue2.Add(2);
            myQueue2.Add(3);
            myQueue2.Add(4);
            myQueue2.Add(5);
            myQueue2.Add(6);
            myQueue2.Add(7);
            myQueue2.Add(8);
            myQueue2.Add(9);
            var reverseKElements = myQueue2.ReverseKElements(3);

            Console.WriteLine();
            Console.WriteLine();
            foreach (var i in reverseKElements)
            {
                Console.Write(i);
            }



            Console.WriteLine();
            Console.WriteLine("------- Array Queue Demo");

            ArrayQueue arrayQueue = new ArrayQueue(5);

            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(2);
            arrayQueue.Enqueue(3);

            Console.WriteLine(arrayQueue.ToString());

            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Dequeue());

            Console.WriteLine(arrayQueue.ToString());

            arrayQueue.Enqueue(4);
            arrayQueue.Enqueue(5);
            arrayQueue.Enqueue(6);
            Console.WriteLine(arrayQueue.ToString());

            arrayQueue.Enqueue(7);
            Console.WriteLine(arrayQueue.ToString());

            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.ToString());

            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.ToString());

            Console.WriteLine("------- Stack Queue Demo");

            StackQueue stackQueue = new StackQueue();

            stackQueue.Enqueue(1);
            stackQueue.Enqueue(2);
            stackQueue.Enqueue(3);
            stackQueue.Enqueue(4);

            Console.WriteLine(stackQueue.Dequeue());
            Console.WriteLine(stackQueue.Dequeue());

            stackQueue.Enqueue(5);
            stackQueue.Enqueue(6);

            Console.WriteLine(stackQueue.Dequeue());
            Console.WriteLine(stackQueue.Dequeue());
            Console.WriteLine(stackQueue.Dequeue());
            Console.WriteLine(stackQueue.Dequeue());
            Console.WriteLine(stackQueue.Dequeue());

            Console.WriteLine("------- Priority Queue Demo");

            PriorityQueue priorityQueue = new PriorityQueue(5);

            priorityQueue.Enqueue(1);
            priorityQueue.Enqueue(3);
            priorityQueue.Enqueue(4);

            Console.WriteLine(priorityQueue.ToString());

            priorityQueue.Enqueue(5);
            priorityQueue.Enqueue(2);

            Console.WriteLine(priorityQueue.ToString());

            Console.WriteLine(priorityQueue.Dequeue());
            Console.WriteLine(priorityQueue.Dequeue());
            Console.WriteLine(priorityQueue.ToString());

            priorityQueue.Enqueue(7);
            priorityQueue.Enqueue(1);
            Console.WriteLine(priorityQueue.ToString());
        }
    }
}
