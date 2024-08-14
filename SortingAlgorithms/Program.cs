// See https://aka.ms/new-console-template for more information
using SortingAlgorithms;

Console.WriteLine("Hello, World!");


var items = new int[] { 5, 4, 3, 2, 1 };

BubbleSort bubbleSort = new BubbleSort();

bubbleSort.Sort(items);

Console.WriteLine(string.Join(", ", items));

items = new int[] { 3, 4, 5, 6, 7 };
bubbleSort.Sort(items);

Console.WriteLine(string.Join(", ", items));