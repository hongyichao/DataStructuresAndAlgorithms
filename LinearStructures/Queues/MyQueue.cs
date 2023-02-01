namespace LinearStructures.Queues
{
    public class MyQueue
    {
        private Queue<int> _queue = new Queue<int>();


        public void Add(int item)
        {
            _queue.Enqueue(item);
        }

        public IEnumerable<int> Reverse()
        {
            return _queue.Reverse();
        }

        public IEnumerable<int> ReverseKElements(int k)
        {
            var array = _queue.ToArray();

            var stack = new Stack<int>();

            for (int i = 0; i <= k - 1; i++)
            {
                stack.Push(array[i]);
            }

            for (int i = 0; i <= k - 1; i++)
            {
                array[i] = stack.Pop();
            }

            return array;
        }

        public override string ToString()
        {
            return string.Join(", ", _queue);
        }

        public IEnumerable<int> ReverseWithStack()
        {
            Stack<int> stack = new Stack<int>();

            while (_queue.Count > 0)
                stack.Push(_queue.Dequeue());

            while (stack.Count > 0)
            {
                _queue.Enqueue(stack.Pop());
            }


            return _queue.ToArray();
        }
    }
}
