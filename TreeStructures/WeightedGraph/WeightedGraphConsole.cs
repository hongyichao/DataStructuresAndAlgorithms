using System;
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

            var weightedGraph2 = new WeightedGraph();

            weightedGraph2.AddNode("A");
            weightedGraph2.AddNode("B");
            weightedGraph2.AddNode("C");
            
            weightedGraph2.AddEdge("A", "B", 1);
            weightedGraph2.AddEdge("B", "C", 2);
            weightedGraph2.AddEdge("A", "C", 10);

            var path = weightedGraph2.GetShortestPath("A", "C");

            Console.WriteLine("The shortest path: " + path);

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

        }
    }
}
