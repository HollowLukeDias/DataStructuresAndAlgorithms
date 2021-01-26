using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.CodingChallenges
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    class BinaryTreeMaxDepth
    {
        public int MaxDepth(TreeNode root)
        {
            var maxRight = 0;
            var maxLeft = 0;
            if (root == null)
                return 0;

            if (root.left == null && root.right == null)
                return 1;

            if (root.left != null)
                maxLeft = MaxDepth(root.left) + 1;

            if (root.right != null)
                maxRight = MaxDepth(root.right) + 1;

            return (maxLeft <= maxRight) ? maxLeft : maxRight;
        }
    }
}
