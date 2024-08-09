using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructures.Graph
{
    public class Graph
    {
        private Dictionary<string, Node> Nodes = new Dictionary<string, Node>();
        private Dictionary<Node, List<Node>> AdjacencyList = new Dictionary<Node, List<Node>>();

        public void AddNode(string label)
        {
            var node = new Node(label);

            Nodes.TryAdd(label, node);

            AdjacencyList.TryAdd(node, new List<Node>());
        }

        public void RemoveNode(string label)
        {
            Nodes.TryGetValue(label, out var node);

            if (node == null)
                return;

            //remove edges
            foreach (var i in AdjacencyList.Keys)
            {
                var nodeList = AdjacencyList[i].Remove(node);
            }

            AdjacencyList.Remove(node);

            Nodes.Remove(label);
        }

        public void AddEdge(string from, string to)
        {
            Nodes.TryGetValue(from, out Node fromNode);
            if (fromNode == null)
                throw new ArgumentException();

            Nodes.TryGetValue(to, out Node toNode);
            if (toNode == null)
                throw new ArgumentException();

            AdjacencyList.TryGetValue(fromNode, out List<Node> fromAdjList);
            fromAdjList.Add(toNode);

        }

        public void RemoveEdge(string from, string to)
        {

            Nodes.TryGetValue(from, out Node fromNode);
            Nodes.TryGetValue(to, out Node toNode);

            if (fromNode == null || toNode == null)
                return;

            AdjacencyList.TryGetValue(fromNode, out List<Node> edges);

            if(edges!=null)
                edges.Remove(toNode);
        }

        public void Print()
        {
            foreach (var s in AdjacencyList.Keys)
            {
                var targets = AdjacencyList[s];

                if (targets.Count > 0)
                {
                    Console.WriteLine($"{s.Label} is connected to {string.Join(", ", targets.Select(t=>t.Label).ToList())}");
                }
            }
        }

        private class Node 
        {
            public string Label { get; set; }
            

            public Node(string label) 
            { 
                Label = label;
            }
        }
    }
}
