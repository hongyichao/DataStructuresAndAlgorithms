using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructures.AvlTree
{
    internal class AvlTreeConsole
    {
        public void Run() 
        { 
            var avlTree = new AvlTree();

            avlTree.Insert(3);
            avlTree.Insert(8);
            avlTree.Insert(7);
            avlTree.Insert(2);
            avlTree.Insert(1);
            avlTree.Insert(10);
            avlTree.Insert(20);
            avlTree.Insert(30);

            Console.WriteLine("is tree balanced? " + avlTree.IsBalanced());


            Console.WriteLine("is tree perfect? " + avlTree.IsTreePerfect());
        }
    }
}
