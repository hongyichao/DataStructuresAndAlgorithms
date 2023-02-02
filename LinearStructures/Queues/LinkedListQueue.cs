using System.Text;

namespace LinearStructures.Queues
{
    public class LinkedListQueue
    {
        private Node _first { get; set; }
        private Node _last { get; set; }
        private int _count { get; set; }

        public LinkedListQueue()
        {
            _count = 0;
        }

        public void Enqueue(int val)
        {
            if (_count == 0)
            {
                _first = new Node(val);
                _last = _first;
            }
            else
            {
                _last.Next = new Node(val);
                _last = _last.Next;
            }

            _count++;
        }

        public int Dequeue()
        {
            if (_count == 0)
                throw new InvalidOperationException();

            var val = _first.Value;

            _first = _first.Next;

            _count--;
            return val;
        }

        public int Peek()
        {
            if (_count == 0)
                throw new InvalidOperationException();

            var val = _first.Value;
            return val;
        }

        public int Size()
        {
            return _count;
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            var current = _first;

            while (current != null)
            {
                sb.Append(current.Value + ",");

                current = current.Next;
            }

            return sb.ToString();
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int val)
        {
            Value = val;
        }

    }
}
