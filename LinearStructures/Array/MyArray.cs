
namespace LinearStructures.Array
{
    internal class MyArray
    {
        private int[] _array;
        private int count=0;

        public MyArray(int length)
        {
            _array = new int[length];
        }

        public void Insert(int number) 
        {
            ResizeArrayWhenFull();
            
            _array[count++] = number;
        }

        public void ResizeArrayWhenFull() 
        {
            if (count == _array.Length)
            {
                var newArray = new int[count * 2];

                for (int i = 0; i < _array.Length; i++)
                    newArray[i] = _array[i];

                _array = newArray;
            }
        }

        public void InsertAt(int index, int item)         
        {
            if (index < 0 || index > count)
                throw new IndexOutOfRangeException();

            ResizeArrayWhenFull();

            for (int i = count - 1; i >= index; i--) 
                _array[i + 1] = _array[i];

            _array[index] = item;
            count++;
        }

        public void RemoveAt(int index) 
        {
            if (index < 0 || index > count)
                return;

            for (int i = index; i < count; i++) 
                _array[i] = _array[i + 1];

            _array[count-1] = 0;
            count--;
        }

        public int IndexOf(int number) 
        {
            for (int i=0; i< count; i++)
                if (_array[i]==number)
                    return i;
            return -1;
        }

        public int Max() 
        {
            int max = -1;
            for (int i = 0; i < count; i++) 
                if (_array[i] > max) 
                    max = _array[i];

            return max;
        }

        public MyArray Intersect(MyArray secondArray) 
        {
            var intersectArray = new MyArray(count);
            
            foreach (var i in _array) 
                if(secondArray.IndexOf(i)>=0) 
                    intersectArray.Insert(i);

            return intersectArray;
        }

        public void Reverse()
        {
            int first = 0;
            int last = count-1;

            while (first < last) 
            {
                var tmp = _array[first];
                _array[first] = _array[last];
                _array[last] = tmp;
                first++;
                last--;
            }            
        }

        public void Print()         
        {
            for (int i=0; i< count; i++)                
                    Console.Write(_array[i]);

            Console.WriteLine();
        }
    }
}
