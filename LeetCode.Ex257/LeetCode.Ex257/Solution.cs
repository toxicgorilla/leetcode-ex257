using System.Collections.Generic;

namespace LeetCode.Ex257
{
    public class Solution
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            var results = GetPaths(root, string.Empty);

            return results;
        }

        private IList<string> GetPaths(TreeNode node, string prefix = "")
        {
            if (node == null)
            {
                return new List<string>();
            }

            var thisNode = prefix + node.val;

            var isLeaf = node.left == null && node.right == null;
            if (isLeaf)
            {
                return new List<string> { thisNode };
            }

            var results = new List<string>();
            if (node.left != null)
            {
                var leftResults = GetPaths(node.left, thisNode + "->");
                results.AddRange(leftResults);
            }

            if (node.right != null)
            {
                var rightResults = GetPaths(node.right, thisNode + "->");
                results.AddRange(rightResults);
            }

            return results;
        }
    }
}
