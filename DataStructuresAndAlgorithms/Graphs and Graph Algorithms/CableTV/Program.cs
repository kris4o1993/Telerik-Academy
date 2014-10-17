namespace CableTV
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dictionary<Node, HashSet<Edge>> town = Input();

            Stopwatch timer = new Stopwatch();

            // Prim's algorithm
            timer.Start();
            int primMin = Prim(town);
            timer.Stop();
            Console.WriteLine(primMin);
            Console.WriteLine("Prim's algorithm performance: " + timer.Elapsed);
            Console.WriteLine();

            // Kruskal's algorithm
            timer.Restart();
            int kruskalMin = Kruskal(town);
            timer.Stop();
            Console.WriteLine(kruskalMin);
            Console.WriteLine("Kruskal's algorithm performance: " + timer.Elapsed);
            Console.WriteLine();
        }

        private static int Kruskal(Dictionary<Node, HashSet<Edge>> town)
        {
            PriorityQueue<Edge> queue = new PriorityQueue<Edge>();
            HashSet<Edge> used = new HashSet<Edge>();
            List<HashSet<Node>> trees = new List<HashSet<Node>>();

            // Add only unique edges (custom Equals method)
            foreach (var node in town)
            {
                foreach (var edge in node.Value)
                {
                    if (!used.Contains(edge))
                    {
                        queue.Enqueue(edge);
                        used.Add(edge);
                        used.Add(new Edge(edge.End, edge.Start, edge.Distance));
                    }
                }

                // Add nodes to different trees
                trees.Add(new HashSet<Node>() { node.Key });
            }

            int minDistance = 0;
            Edge currentEdge;
            while (queue.Count != 0)
            {
                currentEdge = queue.Dequeue();

                if (FindAndUnion(trees, currentEdge))
                {
                    minDistance += currentEdge.Distance;
                }

                // Stop when remain only one tree
                if (trees.Count == 1)
                {
                    break;
                }
            }

            return minDistance;
        }

        private static bool FindAndUnion(List<HashSet<Node>> trees, Edge currentEdge)
        {
            Node[] nodes = new Node[] { currentEdge.Start, currentEdge.End };

            int firstTreeIndex = 0;
            int secondTreeIndex = 0;
            for (int i = 0; i < trees.Count; i++)
            {
                if (trees[i].IsSupersetOf(nodes))
                {
                    return false;
                }

                if (trees[i].Contains(currentEdge.Start))
                {
                    firstTreeIndex = i;
                    continue;
                }

                if (trees[i].Contains(currentEdge.End))
                {
                    secondTreeIndex = i;
                    continue;
                }
            }

            trees[firstTreeIndex].UnionWith(trees[secondTreeIndex]);
            trees.RemoveAt(secondTreeIndex);
            return true;
        }

        private static int Prim(Dictionary<Node, HashSet<Edge>> town)
        {
            // Random
            Node root = town.First().Key;
            root.Distance = 0;

            PriorityQueue<Node> queue = new PriorityQueue<Node>();
            queue.Enqueue(root);

            HashSet<Node> used = new HashSet<Node>();

            int minDistance = 0;
            Node currentNode;
            while (queue.Count != 0)
            {
                currentNode = queue.Dequeue();

                if (used.Contains(currentNode))
                {
                    continue;
                }

                used.Add(currentNode);
                minDistance += currentNode.Distance;

                foreach (Edge edge in town[currentNode])
                {
                    if (!used.Contains(edge.End))
                    {
                        edge.End.Distance = edge.Distance;
                        queue.Enqueue(edge.End);
                    }
                }
            }

            return minDistance;
        }

        private static Dictionary<Node, HashSet<Edge>> Input()
        {
            Dictionary<Node, HashSet<Edge>> town = new Dictionary<Node, HashSet<Edge>>();

            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Node nodeC = new Node("C");
            Node nodeD = new Node("D");
            Node nodeE = new Node("E");
            Node nodeF = new Node("F");
            Node nodeG = new Node("G");
            Node nodeH = new Node("H");
            Node nodeI = new Node("I");

            town.Add(nodeA, new HashSet<Edge>());
            town.Add(nodeB, new HashSet<Edge>());
            town.Add(nodeC, new HashSet<Edge>());
            town.Add(nodeD, new HashSet<Edge>());
            town.Add(nodeE, new HashSet<Edge>());
            town.Add(nodeF, new HashSet<Edge>());
            town.Add(nodeG, new HashSet<Edge>());
            town.Add(nodeH, new HashSet<Edge>());
            town.Add(nodeI, new HashSet<Edge>());

            town[nodeA].Add(new Edge(nodeA, nodeB, 2));
            town[nodeA].Add(new Edge(nodeA, nodeG, 4));

            town[nodeB].Add(new Edge(nodeB, nodeA, 2));
            town[nodeB].Add(new Edge(nodeB, nodeC, 4));
            town[nodeB].Add(new Edge(nodeB, nodeD, 2));
            town[nodeB].Add(new Edge(nodeB, nodeG, 6));

            town[nodeC].Add(new Edge(nodeC, nodeB, 4));
            town[nodeC].Add(new Edge(nodeC, nodeD, 3));

            town[nodeD].Add(new Edge(nodeD, nodeB, 2));
            town[nodeD].Add(new Edge(nodeD, nodeC, 3));
            town[nodeD].Add(new Edge(nodeD, nodeE, 5));
            town[nodeD].Add(new Edge(nodeD, nodeF, 3));

            town[nodeE].Add(new Edge(nodeE, nodeD, 5));
            town[nodeE].Add(new Edge(nodeE, nodeF, 3));
            town[nodeE].Add(new Edge(nodeE, nodeH, 4));

            town[nodeF].Add(new Edge(nodeF, nodeD, 3));
            town[nodeF].Add(new Edge(nodeF, nodeE, 3));
            town[nodeF].Add(new Edge(nodeF, nodeG, 5));
            town[nodeF].Add(new Edge(nodeF, nodeH, 4));

            town[nodeG].Add(new Edge(nodeG, nodeA, 4));
            town[nodeG].Add(new Edge(nodeG, nodeB, 6));
            town[nodeG].Add(new Edge(nodeG, nodeF, 5));
            town[nodeG].Add(new Edge(nodeG, nodeI, 2));

            town[nodeH].Add(new Edge(nodeH, nodeE, 4));
            town[nodeH].Add(new Edge(nodeH, nodeF, 4));
            town[nodeH].Add(new Edge(nodeH, nodeI, 3));

            town[nodeI].Add(new Edge(nodeI, nodeG, 2));
            town[nodeI].Add(new Edge(nodeI, nodeH, 3));

            return town;
        }
    }
}
