using System;
using System.Collections.Generic;
using System.Text;

namespace OctoberLeetcodeChallenge.Oct8
{
    public class Codec
    {

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            if (root == null) return String.Empty;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            StringBuilder sb = new StringBuilder();
            while(queue.Count > 0)
            {
                var node = queue.Dequeue();
                ushort x = (ushort)(node.val & 0xffff);


                ushort flags = 0;
                if (node.left != null)
                {
                    flags = 10;
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    flags += 1;
                    queue.Enqueue(node.right);
                }


                flags = (ushort)(flags << 14);

                x = (ushort)(flags | x);
                char c = Convert.ToChar(x);
                sb.Append(c);
            };

            return sb.ToString();

        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            if (data == string.Empty) return null;

            var charQueue = new Queue<(bool hasLeft, bool hasRight, int val)>();
            foreach(char c in data)
            {
                ushort encoded = Convert.ToUInt16(c);
                bool hasLeft = (encoded & 0x8000) == 0x8000;
                bool hasRight = (encoded & 0x4000) == 0x4000;
                int val = encoded & 0x3fff;
                charQueue.Enqueue((hasLeft, hasRight, val));
            }

            var queue = new Queue<TreeNode>();
            var root = new TreeNode(0);
            queue.Enqueue(root);

            while(charQueue.Count > 0)
            {
                var ch = charQueue.Dequeue();
                var node = queue.Dequeue();
                node.val = ch.val;
                if (ch.hasLeft)
                {
                    node.left = new TreeNode(0);
                    queue.Enqueue(node.left);
                }

                if(ch.hasRight)
                {
                    node.right = new TreeNode(0);
                    queue.Enqueue(node.right);
                }
            }
            return root;
        }
    }
}
