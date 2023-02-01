namespace LinearStructures.Stacks
{
    public class TwoStacks
    {
        private int[] _array;
        private int _top1;
        private int _top2;

        public TwoStacks(int capacity)
        {
            _array = new int[capacity];
            _top1 = -1;
            _top2 = capacity;
        }

        public void Push1(int val)
        {
            if (IsStack1Full())
                return;
            _top1++;
            _array[_top1] = val;
        }

        public void Push2(int val)
        {
            if (IsStack2Full())
                return;
            _top2--;
            _array[_top2] = val;
        }

        public int? Pop1()
        {
            if (IsStack1Empty())
                throw new InvalidOperationException();

            return _array[_top1--];
        }

        public int Pop2()
        {
            if (IsStack2Empty())
                throw new InvalidOperationException();

            return _array[_top2++];
        }

        public bool IsStack1Full()
        {
            return (_top1 + 1) == _top2;
        }

        public bool IsStack2Full()
        {
            return (_top2 - 1) == _top1;
        }

        public bool IsStack1Empty()
        {
            return _top1 == -1;
        }

        public bool IsStack2Empty()
        {
            return _top2 == _array.Length;
        }

    }
}
