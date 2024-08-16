﻿// See https://aka.ms/new-console-template for more information
using SortingAlgorithms;

Console.WriteLine("Hello, World!");


var items = new int[] { 5, 4, 3, 2, 1 };

BubbleSort bubbleSort = new BubbleSort();

bubbleSort.Sort(items);

Console.WriteLine(string.Join(", ", items));

items = new int[] { 3, 4, 5, 6, 7 };
bubbleSort.Sort(items);

Console.WriteLine(string.Join(", ", items));



items = new int[] { 5, 4, 3, 2, 1 };

SelectionSort selectionSort = new SelectionSort();

var result = selectionSort.Sort(items);

Console.WriteLine(string.Join(", ", result));

InsertionSort insertionSort = new InsertionSort();


items = new int[] { 5, 4, 3, 2, 1 };
var result2 =  insertionSort.Sort(items);
Console.WriteLine(string.Join(", ", result2));

items = new int[] { 1, 1, 4, 7, 5, 4, 2 };
result2 = insertionSort.Sort(items);
Console.WriteLine(string.Join(", ", result2));

items = new int[] { 7, 5};
result2 = insertionSort.Sort(items);
Console.WriteLine(string.Join(", ", result2));