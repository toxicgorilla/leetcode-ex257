using Xunit;

namespace LeetCode.Ex257.Test
{
    public class TreeNodeTheoryData : TheoryData<TreeNode, string[]>
    {
        public TreeNodeTheoryData()
        {
            var rootNode = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(5)
                }, 
                right = new TreeNode(3)
            };

            this.Add(rootNode, new []{ "1->2->5", "1->3" });
        }
    }
}
