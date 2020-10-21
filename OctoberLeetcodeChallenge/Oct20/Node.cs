using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OctoberLeetcodeChallenge.Oct20
{
    [DebuggerDisplay("[{val}]")]
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
}
