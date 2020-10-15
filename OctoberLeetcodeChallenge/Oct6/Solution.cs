using System;
using System.Collections.Generic;
using System.Text;

namespace OctoberLeetcodeChallenge.Oct6
{
    public class Solution
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null)
            {
                root = new TreeNode(val);
            }
            else if (val > root.val)
            {
                root.right = InsertIntoBST(root.right, val);
            }
            else
            {
                root.right = InsertIntoBST(root.left, val);
            }
            return root;
        }
    }
}
