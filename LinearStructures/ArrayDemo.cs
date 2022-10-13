using LinearStructures.Array;

namespace LinearStructures
{
    internal class ArrayDemo
    {
        public static void Run() 
        {
            MyArray array = new MyArray(5);

            array.Insert(1);
            array.Insert(2);
            array.Insert(3);
            array.Insert(4);
            array.Insert(7);
            array.Insert(5);
            array.Insert(6);
            array.Insert(9);
            array.Print();

            array.InsertAt(3, 8);
            array.Print();

            array.RemoveAt(2);
            array.Print();


            Console.WriteLine(array.IndexOf(5));
            Console.WriteLine(array.IndexOf(15));
            Console.WriteLine(array.Max());

            var secondArray = new MyArray(5);
            secondArray.Insert(1);
            secondArray.Insert(2);
            secondArray.Insert(3);
            var intersect = array.Intersect(secondArray);
            intersect.Print();

            array.Reverse();
            array.Print();
        }
    }
}
