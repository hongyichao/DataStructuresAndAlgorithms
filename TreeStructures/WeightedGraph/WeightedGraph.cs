using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TreeStructures.WeightedGraph
{
    public class WeightedGraph
    {
        Dictionary<string, Node> Nodes = new Dictionary<string, Node>();
        
        public void AddNode(string name) 
        {
            if (!Nodes.ContainsKey(name)) 
            {
                var node = new Node(name);

                Nodes.Add(name, node);
            }
        }

        public void AddEdge(string fromName, string toName, int weight) 
        {
            if (!Nodes.TryGetValue(fromName, out Node fromNode))
                throw new Exception($"Node {fromName} not existing");

            if (!Nodes.TryGetValue(toName, out Node toNode))
                throw new Exception($"Node {toName} not existing");

            fromNode.AddEdge(toNode, weight);
            toNode.AddEdge(fromNode, weight);
        }

        public void Print() 
        {
            foreach (var node in Nodes.Values) 
            {
                var edges = node.GetEdges();
                if(edges.Count>0)
                    Console.WriteLine($"{node} is connected to {string.Join(", ", edges)}");
            }
        }

        public string GetShortestPath(String from, String to) 
        {
            if (!Nodes.TryGetValue(from, out Node fromNode))
                throw new Exception($"Node {from} not existing");

            if (!Nodes.TryGetValue(to, out Node toNode))
                throw new Exception($"Node {to} not existing");

            Dictionary<Node, Route> routes = new Dictionary<Node, Route>();

            foreach (var node in Nodes.Values) 
            {
                routes.Add(node, new Route(int.MaxValue, null));
            }

            routes[fromNode] = new Route(0, null);

            HashSet<Node> visited = new HashSet<Node>();

            PriorityQueue<Node, int> queue = new PriorityQueue<Node, int>();

            queue.Enqueue(fromNode, 0);

            while (queue.Count > 0) 
            {
                var current = queue.Dequeue();

                visited.Add(current);

                foreach (var edge in current.GetEdges()) 
                {
                    if (visited.Contains(edge.To))
                        continue;

                    routes.TryGetValue(current, out Route route);

                    var newDistance = route.Distance + edge.Weight;

                    routes.TryGetValue(edge.To, out Route toRoute);

                    if (newDistance < toRoute.Distance) 
                    {
                        routes[edge.To].Distance = newDistance;
                        routes[edge.To].PreviousNode = current;
                        queue.Enqueue(edge.To, newDistance);
                    }
                }
            }

            return BuildPath(routes, toNode);

        }

        private string BuildPath(Dictionary<Node, Route> routes, Node toNode) 
        {
            Stack<Node> stack = new Stack<Node>();

            stack.Push(toNode);

            routes.TryGetValue(toNode, out Route route);
            while (route.PreviousNode != null) 
            {
                stack.Push(route.PreviousNode);
                routes.TryGetValue(route.PreviousNode, out route);
            }

            List<string> path = new List<string>();

            while (stack.Count > 0)
            {
                path.Add(stack.Pop().ToString());
            }

            return string.Join("-> ", path);

        }


        private class Edge 
        {
            public Node From { get; set; }
            public Node To { get; set; }
            public int Weight { get; set; }

            public Edge(Node from, Node to, int weight) 
            { 
                From = from;
                To = to;
                Weight = weight;
            }

            public override string ToString()
            {
                return From +"->" + To; // A->B
            }
        }

        private class Node 
        {
            private string _name;
            private List<Edge> _edges = new List<Edge>();
            public Node(string name) 
            { 
                _name = name;
            }

            public void AddEdge(Node to, int weight)
            {
                _edges.Add(new Edge(this, to, weight));
            }

            public List<Edge> GetEdges() 
            {
                return _edges;
            }

            public override string ToString() 
            {
                return _name;
            }
        }

        private class Route
        {
            public int Distance;
            public Node PreviousNode;

            public Route(int distance, Node previous)
            {
                Distance = distance;
                PreviousNode = previous;
            }
        }

    }
}