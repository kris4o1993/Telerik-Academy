namespace FriendsOfPesho
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            // Read input and initialize graph
            string[] nmh = Console.ReadLine().Split(' ');
            int nodesCount = int.Parse(nmh[0]);
            int edgesCount = int.Parse(nmh[1]);

            HashSet<int> indexesOfHospitals = new HashSet<int>(Console.ReadLine().Split(' ').Select(x => int.Parse(x)));

            Dictionary<int, Node> nodes = new Dictionary<int, Node>(nodesCount);
            for (int i = 0; i < nodesCount; i++)
            {
                nodes.Add(i + 1, new Node(i + 1));
            }

            Dictionary<Node, List<Edge>> map = new Dictionary<Node, List<Edge>>();
            for (int i = 0; i < edgesCount; i++)
            {
                int[] @params = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

                Node first = nodes[@params[0]];
                Node second = nodes[@params[1]];
                int distance = @params[2];

                if (map.ContainsKey(first))
                {
                    map[first].Add(new Edge(second, distance));
                }
                else
                {
                    map.Add(first, new List<Edge>());
                    map[first].Add(new Edge(second, distance));
                }

                if (map.ContainsKey(second))
                {
                    map[second].Add(new Edge(first, distance));
                }
                else
                {
                    map.Add(second, new List<Edge>());
                    map[second].Add(new Edge(first, distance));
                }
            }

            // Solution
            int minDistance = int.MaxValue;
            foreach (int hospital in indexesOfHospitals)
            {
                Dijkstra(map, nodes[hospital]);

                int currentDistance = 0;
                foreach (KeyValuePair<Node, List<Edge>> pair in map)
                {
                    if (!indexesOfHospitals.Contains(pair.Key.Index))
                    {
                        currentDistance += pair.Key.DijkstraDistance;
                    }
                }

                if (currentDistance < minDistance)
                {
                    minDistance = currentDistance;
                }
            }

            // Output
            Console.WriteLine(minDistance);
        }
  
        private static void Dijkstra(Dictionary<Node, List<Edge>> map, Node source)
        {
            PriorityQueue<Node> queue = new PriorityQueue<Node>();

            foreach (KeyValuePair<Node, List<Edge>> pair in map)
            {
                if (pair.Key.Index != source.Index)
                {
                    queue.Enqueue(pair.Key);
                    pair.Key.DijkstraDistance = int.MaxValue;
                }
            }

            source.DijkstraDistance = 0;
            queue.Enqueue(source);

            Node currentNode;
            while (queue.Count != 0)
            {
                currentNode = queue.Peek();

                if (currentNode.DijkstraDistance == int.MaxValue)
                {
                    break;
                }

                foreach (Edge edge in map[currentNode])
                {
                    int potDistance = currentNode.DijkstraDistance + edge.Distance;

                    if (potDistance < edge.Node.DijkstraDistance)
                    {
                        edge.Node.DijkstraDistance = potDistance;
                        Node nextNode = new Node(edge.Node.Index);
                        nextNode.DijkstraDistance = potDistance;
                        queue.Enqueue(nextNode);
                    }
                }

                queue.Dequeue();
            }
        }
    }
}
