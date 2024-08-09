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

        public bool HasCycle() 
        {
            HashSet<Node> all = Nodes.Values.ToHashSet();
            HashSet<Node> visiting = new HashSet<Node>();
            HashSet<Node> visited = new HashSet<Node>();

            while (all.Count > 0) 
            {
                var current = all.ToArray()[0];

                if (HasCycle(current, all, visiting, visited))
                    return true;

            }

            return false;
        }

        private bool HasCycle(Node node, HashSet<Node> all,
            HashSet<Node> visiting, HashSet<Node> visited) 
        {
            all.Remove(node);

            visiting.Add(node);

            foreach (var n in AdjacencyList[node]) 
            {
                if (visited.Contains(n))
                    continue;

                if (visiting.Contains(n))
                    return true;

                if(HasCycle(n, all, visiting, visited))
                    return true;
            }

            visiting.Clear();   
            visited.Add(node);
            return false;
        }


        public List<string> TopologicalSort() 
        {
            HashSet<Node> visited = new HashSet<Node>();
            Stack<Node> stack = new Stack<Node>();

            foreach (var node in Nodes.Values) 
                TopologicalSort(node, visited, stack);

            List<string> sorted = new List<string>();

            while (stack.Count > 0) 
                sorted.Add(stack.Pop().Label);

            return sorted;
        }

        private void TopologicalSort(Node node, HashSet<Node> visited, Stack<Node> stack) 
        {
            
            if(visited.Contains(node))
                return;

            visited.Add(node);

            foreach (var n in AdjacencyList[node]) 
                TopologicalSort(n, visited, stack);

            stack.Push(node);
        }

        public void TraverseBreadthFirst(string label)
        {
            Nodes.TryGetValue(label, out Node node);

            if (node == null)
                return;

            var visited = new HashSet<Node>();
            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(node);

            while (queue.Count > 0) 
            {
                var current = queue.Dequeue();

                if (visited.Contains(current))
                    continue;

                visited.Add(current);

                foreach (var neighbour in AdjacencyList[current]) 
                {
                    if (!visited.Contains(neighbour)) 
                        queue.Enqueue(neighbour);
                }
            }

            Console.WriteLine(string.Join(",", visited.Select(n => n.Label).ToList()));
        }
        public void IterativeTraverseDepthFirst(string label) 
        {
            Nodes.TryGetValue(label, out Node node);

            if (node == null)
                return;


            var visited = new HashSet<Node>();
            var stack = new Stack<Node>();

            stack.Push(node);

            while (stack.Count > 0) 
            {
                var current = stack.Pop();

                if (visited.Contains(current))
                    continue;

                visited.Add(current);

                foreach (var neighbour in AdjacencyList[current])
                {
                    if(!visited.Contains(neighbour))
                        stack.Push(neighbour);
                }
            }


            Console.WriteLine(string.Join(",", visited.Select(n => n.Label).ToList()));
        }


        public void TraverseDepthFirst(string label) 
        {
            Nodes.TryGetValue(label, out Node node);

            if (node == null)
                return;

            var nodesToReturn = new HashSet<Node>();

            TraverseDepthFirst(node, nodesToReturn);

            Console.WriteLine(string.Join(",", nodesToReturn.Select(n => n.Label).ToList()));

        }


        private void TraverseDepthFirst(Node node, HashSet<Node> nodesToReturn) 
        {
            nodesToReturn.Add(node);

            foreach (var n in AdjacencyList[node])
            {
                if(!nodesToReturn.Contains(n))
                    TraverseDepthFirst(n, nodesToReturn);
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
