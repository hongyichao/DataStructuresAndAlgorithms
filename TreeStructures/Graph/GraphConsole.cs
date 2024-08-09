using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructures.Graph
{
    public class GraphConsole
    {
        public void Run() 
        {
            var graph = new Graph();

            graph.AddNode("A");            
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");
            graph.AddNode("F");
                
            graph.AddEdge("A", "B");
            graph.AddEdge("A", "C");
            graph.AddEdge("B", "D");
            graph.AddEdge("C", "E");
            graph.AddEdge("C", "F");

            graph.Print();

            Console.WriteLine("-----------------------------------");

            graph.RemoveEdge("A", "B");

            graph.RemoveNode("C");

            graph.Print();

            Console.WriteLine("-----------------------------------");
            graph.AddNode("C");
            graph.AddEdge("A", "B");

            graph.AddEdge("A", "C");


            graph.Print();
            graph.TraverseDepthFirst("A");
            graph.IterativeTraverseDepthFirst("A");

            graph.AddEdge("D", "E");
            graph.AddEdge("D", "F");

            graph.TraverseBreadthFirst("A");


            Console.WriteLine("-----------------------------------");

            var strList = graph.TopologicalSort();

            Console.WriteLine(string.Join(", ", strList));

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("has cycle: " + graph.HasCycle());

            graph.AddEdge("C", "A");

            Console.WriteLine("has cycle: " + graph.HasCycle());

        }
    }
}
