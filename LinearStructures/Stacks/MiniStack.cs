namespace LinearStructures.Stacks
{
    public class MiniStack
    {
        private Stack<int> _values = new Stack<int>();
        private Stack<int> _mins = new Stack<int>();

        public void Push(int val)
        {
            _values.Push(val);

            if (_mins.Count == 0)
                _mins.Push(val);
            else
            {
                if (val <= _mins.Peek())
                    _mins.Push(val);
            }
        }

        public int Pop()
        {
            if (_values.Count == 0)
                throw new InvalidOperationException();

            var top = _values.Pop();

            if (top == _mins.Peek())
                _mins.Pop();

            return top;
        }

        public int GetMin()
        {
            return _mins.Peek();
        }
    }
}
