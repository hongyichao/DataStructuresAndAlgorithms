using System.Text;

namespace LinearStructures.Stacks
{
    public class MyStack
    {
        private List<char> _leftBrackets = new List<char>() { '(', '{', '[', '<' };
        private List<char> _rightBrackets = new List<char>() { ')', '}', ']', '>' };


        private int _maxNumber = 5;
        private int _count = 0;
        private int[] _values;

        public MyStack()
        {
            _values = new int[_maxNumber];
        }

        public void Push(int value)
        {
            if (IsFull())
                throw new InvalidOperationException();

            _values[_count] = value;
            _count++;
        }

        public int Pop()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException();

            var valToReturn = _values[_count - 1];
            _count--;
            return valToReturn;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException();

            var valToReturn = _values[_count - 1];
            return valToReturn;
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public bool IsFull()
        {
            return _count == _maxNumber;
        }



        public string ReverseString(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return str;

            Stack<char> chars = new Stack<char>();

            foreach (var c in str)
            {
                chars.Push(c);
            }

            StringBuilder stringBuilder = new StringBuilder();

            while (chars.Count > 0)
            {
                stringBuilder.Append(chars.Pop());
            }
            return stringBuilder.ToString();
        }

        public bool IsBalancedExpressionString(string input)
        {
            Stack<char> chars = new Stack<char>();

            foreach (var c in input)
            {
                if (IsOpeningBracket(c))
                    chars.Push(c);

                if (IsClosingBracket(c))
                {
                    if (chars.Count == 0)
                        return false;

                    var previousChar = chars.Pop();
                    if (!IsBracketsMatched(previousChar, c))
                        return false;
                }
            }


            return true;
        }

        private bool IsOpeningBracket(char c)
        {
            return _leftBrackets.Contains(c);
        }

        private bool IsClosingBracket(char c)
        {
            return _rightBrackets.Contains(c);
        }

        private bool IsBracketsMatched(char leftBracket, char rightBracket)
        {
            return _leftBrackets.IndexOf(leftBracket) == _rightBrackets.IndexOf(rightBracket);
        }
    }
}
