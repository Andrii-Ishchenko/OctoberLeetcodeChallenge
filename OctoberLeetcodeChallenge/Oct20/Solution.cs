using System;
using System.Collections.Generic;
using System.Text;

namespace OctoberLeetcodeChallenge.Oct20
{
    class Solution
    {
        public Node CloneGraph(Node node)
        {
            if(node == null)
            {
                return null;
            }

            Dictionary<int, Node> nodes = new Dictionary<int, Node>();
            Queue<Node> queue = new Queue<Node>();
            HashSet<int> visited = new HashSet<int>();

            nodes[node.val] = new Node(node.val);
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (visited.Contains(current.val)) continue;

                var currentNew = nodes[current.val];
                foreach (var nei in current.neighbors)
                {
                    if (!nodes.ContainsKey(nei.val))
                    {
                        var newNeighbour = new Node(nei.val);
                        nodes[nei.val] = newNeighbour;                   
                    }

                    currentNew.neighbors.Add(nodes[nei.val]);
                    if (!visited.Contains(nei.val))
                    {
                        queue.Enqueue(nei);
                    }                
                }
                visited.Add(current.val);
            }
            return nodes[node.val];
        }
    }
}
