

using TreeStructures.BinaryTree;

BinaryTree binaryTree = new BinaryTree();

binaryTree.Insert(100);
binaryTree.Insert(90);
binaryTree.Insert(80);
binaryTree.Insert(70);
binaryTree.Insert(75);
binaryTree.Insert(110);
binaryTree.Insert(105);
binaryTree.Insert(120);

var searchResult = binaryTree.Find(75);
Console.WriteLine(searchResult);

searchResult = binaryTree.Find(110);
Console.WriteLine(searchResult);

searchResult = binaryTree.Find(200);
Console.WriteLine(searchResult);

Console.WriteLine();
Console.WriteLine("PrintByPreOrderTraverse");
binaryTree.PrintByPreOrderTraverse();

Console.WriteLine();
Console.WriteLine("PrintByInOrderTraverse");
binaryTree.PrintByInOrderTraverse(false);

Console.WriteLine();
Console.WriteLine("PrintByInOrderTraverse");
binaryTree.PrintByInOrderTraverse(true);

Console.WriteLine();
Console.WriteLine("PrintByPostOrderTraverse");
binaryTree.PrintByPostOrderTraverse();


Console.WriteLine("done");