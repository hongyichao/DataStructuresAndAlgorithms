

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
binaryTree.Insert(5);



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

Console.WriteLine();
Console.WriteLine("Height of the root:" + Convert.ToString(binaryTree.Height()));



Console.WriteLine();
Console.WriteLine("Min of the root:" + Convert.ToString(binaryTree.Min()));

BinaryTree otherTree = new BinaryTree();

otherTree.Insert(100);
otherTree.Insert(90);
otherTree.Insert(80);
otherTree.Insert(70);
otherTree.Insert(75);
otherTree.Insert(110);
otherTree.Insert(105);
otherTree.Insert(120);
otherTree.Insert(5);

Console.WriteLine();
Console.WriteLine("Are the 2 trees equal? " + binaryTree.Equal(otherTree));

Console.WriteLine();
Console.WriteLine("Is binary tree valid? " + binaryTree.Validate());
Console.WriteLine("Is binary tree valid? " + otherTree.Validate());

binaryTree.SwapRoot();
Console.WriteLine("Is binary tree valid? " + binaryTree.Validate());


otherTree.Insert(130);
Console.WriteLine("Node at distance: " + String.Join(", ", otherTree.GetNodeAtGivenDistance(3)));


Console.WriteLine("done");

