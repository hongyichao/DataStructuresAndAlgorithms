namespace LinearStructures.Queues
{
    public class ArrayQueue
    {
        private int[] _values;
        private int _rear;
        private int _front;
        private int _count;

        public ArrayQueue(int length)
        {
            _values = new int[length];
            _rear = 0;
            _count = 0;
            _front = 0;
        }

        public void Enqueue(int val)
        {
            if (IsFull())
                return;

            _values[_rear] = val;
            _rear = (_rear + 1) % _values.Length;
            _count++;
        }

        public int Dequeue()
        {
            if (IsEmpty())
                return -1;

            var val = _values[_front];
            _values[_front] = 0;
            _front = (_front + 1) % _values.Length;
            _count--;
            return val;
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public bool IsFull()
        {
            return _count == _values.Length;
        }

        public override string ToString()
        {
            return string.Join(", ", _values);
        }
    }
}
