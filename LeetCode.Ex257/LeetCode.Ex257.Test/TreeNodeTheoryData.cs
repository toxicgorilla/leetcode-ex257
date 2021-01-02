using System.Collections.Generic;
using Xunit;

namespace LeetCode.Ex257.Test
{
    public class TreeNodeTheoryData : TheoryData<TreeNode, IList<string>>
    {
        public TreeNodeTheoryData()
        {
            var example1Input = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(5)
                }, 
                right = new TreeNode(3)
            };

            var example1Output = new List<string> { "1->2->5", "1->3" };

            this.Add(example1Input, example1Output);

            var example2Input = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4)
                    {
                        left = new TreeNode(7),
                        right = new TreeNode(8)
                    },
                    right = new TreeNode(5)
                    {
                        left = new TreeNode(9)
                    }
                },
                right = new TreeNode(3)
            };

            var example2Output = new List<string> { "1->2->4->7", "1->2->4->8", "1->2->5->9", "1->3" };


            this.Add(example2Input, example2Output);
        }
    }
}
