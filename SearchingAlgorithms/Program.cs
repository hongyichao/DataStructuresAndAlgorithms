
using SearchingAlgorithms;

Search search = new Search();

var items = new int[] 
{
    1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16
};


var index = search.LinearSearch(items, 11);
Console.WriteLine("found item at: " + index);

index = search.BinarySearch(items, 11);
Console.WriteLine("found item at: " + index);

index = search.BinarySearchRec(items, 11);
Console.WriteLine("found item at: " + index);