using LinearStructures.Stacks;

namespace LinearStructures
{
    public class StackDemo
    {
        public static void Run()
        {
            MyStack myStack = new MyStack();

            Console.WriteLine(myStack.ReverseString("abcdefg"));

            string testStr = "<((A)[(B)]{C}D>)>";
            var isBalanced = myStack.IsBalancedExpressionString(testStr);

            Console.WriteLine($"The string {testStr} is balanced string: " + isBalanced);

            myStack.Push(5);
            myStack.Push(4);
            myStack.Push(3);
            myStack.Push(2);
            myStack.Push(1);

            Console.WriteLine(myStack.Peek());

            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());

            Console.WriteLine("-------Array Two Stacks Demo");

            TwoStacks twoStacks = new TwoStacks(5);

            twoStacks.Push1(5);
            twoStacks.Push1(4);
            twoStacks.Push1(3);
            twoStacks.Push2(2);
            twoStacks.Push2(1);
            twoStacks.Push2(0);

            Console.WriteLine();
            Console.WriteLine("Print Stack 1");
            Console.Write(twoStacks.Pop1());
            Console.Write(twoStacks.Pop1());
            Console.Write(twoStacks.Pop1());
            Console.WriteLine();
            try
            {
                Console.Write(twoStacks.Pop1());
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }

            twoStacks.Push2(7);
            twoStacks.Push2(8);
            twoStacks.Push2(9);

            Console.WriteLine("Print Stack 2");
            Console.Write(twoStacks.Pop2());
            Console.Write(twoStacks.Pop2());
            Console.Write(twoStacks.Pop2());
            Console.Write(twoStacks.Pop2());
            Console.Write(twoStacks.Pop2());
            Console.WriteLine();
            try
            {
                Console.Write(twoStacks.Pop2());
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }

            Console.WriteLine("-------Mini Stacks Demo");

            MiniStack miniStack = new MiniStack();

            miniStack.Push(10);
            miniStack.Push(3);
            miniStack.Push(2);
            miniStack.Push(1);
            miniStack.Push(7);
            miniStack.Push(8);

            Console.WriteLine($"Mini: {miniStack.GetMin()}");

            miniStack.Pop();
            miniStack.Pop();
            miniStack.Pop();

            Console.WriteLine($"Mini: {miniStack.GetMin()}");


            miniStack.Pop();
            Console.WriteLine($"Mini: {miniStack.GetMin()}");

            miniStack.Pop();
            Console.WriteLine($"Mini: {miniStack.GetMin()}");
        }
    }
}

