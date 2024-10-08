﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructures.WeightedGraph
{
    public class WeightedGraphConsole
    {
        public void Run() 
        {
            var weightedGraph = new WeightedGraph();

            weightedGraph.AddNode("A");
            weightedGraph.AddNode("B");
            weightedGraph.AddNode("C");
            weightedGraph.AddNode("D");

            weightedGraph.AddEdge("A", "B", 3);
            weightedGraph.AddEdge("A", "C", 2);
            weightedGraph.AddEdge("C", "D", 4);
            weightedGraph.AddEdge("A", "D", 2);

            weightedGraph.Print();

            Console.WriteLine("--------Graph 2---------Start---------------");
            var weightedGraph2 = new WeightedGraph();

            weightedGraph2.AddNode("A");
            weightedGraph2.AddNode("B");
            weightedGraph2.AddNode("C");
            
            weightedGraph2.AddEdge("A", "B", 1);
            weightedGraph2.AddEdge("B", "C", 2);
            

            var path = weightedGraph2.GetShortestPath("A", "C");
            Console.WriteLine("The shortest path: " + path);

            
            weightedGraph2.Print();

            Console.WriteLine("--------Graph 2---------End---------------");


            Console.WriteLine("--------Graph 3---------Start-----");
            var weightedGraph3 = new WeightedGraph();

            weightedGraph3.AddNode("A");
            weightedGraph3.AddNode("B");
            weightedGraph3.AddNode("C");
            weightedGraph3.AddNode("D");
            weightedGraph3.AddNode("E");

            weightedGraph3.AddEdge("A", "B", 3);
            weightedGraph3.AddEdge("A", "C", 2);
            weightedGraph3.AddEdge("A", "D", 5);
            weightedGraph3.AddEdge("B", "C", 4);
            weightedGraph3.AddEdge("C", "D", 1);
            weightedGraph3.AddEdge("C", "E", 3);


            path = weightedGraph3.GetShortestPath("A", "D");

            Console.WriteLine("The shortest path: " + path);

            Console.WriteLine("----------------------------------");
            weightedGraph3.Print();

            Console.WriteLine("Graph 3 Has cycle: " + weightedGraph3.HasCycle());

            Console.WriteLine("--------Graph 3---------End-----");

            Console.WriteLine("Graph 2 Has cycle: " + weightedGraph2.HasCycle());

            Console.WriteLine("Graph 1 Has cycle: " + weightedGraph.HasCycle());

            Console.WriteLine("--------Graph 4---------Start-----");

            var weightedGraph4 = new WeightedGraph();

            weightedGraph4.AddNode("A");
            weightedGraph4.AddNode("B");
            weightedGraph4.AddNode("C");
            weightedGraph4.AddNode("D");
            

            weightedGraph4.AddEdge("A", "B", 3);
            weightedGraph4.AddEdge("B", "D", 4);
            weightedGraph4.AddEdge("C", "D", 5);
            weightedGraph4.AddEdge("A", "C", 1);
            weightedGraph4.AddEdge("B", "C", 2);


            var spanningTree = weightedGraph4.GetMinimumSpanningTree();


            Console.WriteLine("-----------Spanning tree-------------");
            spanningTree.Print();

        }
    }
}
