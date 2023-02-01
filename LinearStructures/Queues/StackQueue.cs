namespace LinearStructures.Queues
{
    public class StackQueue
    {
        private Stack<int> stack1 = new Stack<int>();
        private Stack<int> stack2 = new Stack<int>();

        public void Enqueue(int val)
        {
            stack1.Push(val);
        }

        public int Dequeue()
        {
            if (stack2.Count == 0)
                while (stack1.Count != 0)
                    stack2.Push(stack1.Pop());

            if (stack2.Count > 0)
                return stack2.Pop();

            return -1;
        }

        public int Peek()
        {
            if (stack2.Count == 0)
                while (stack1.Count != 0)
                    stack2.Push(stack1.Pop());

            if (stack2.Count > 0)
                return stack2.Peek();

            return -1;
        }

    }
}
