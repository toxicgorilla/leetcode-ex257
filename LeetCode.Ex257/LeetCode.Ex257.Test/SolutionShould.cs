using Should;
using Xunit;

namespace LeetCode.Ex257.Test
{
    public class SolutionShould
    {
        [Theory]
        [ClassData(typeof(TreeNodeTheoryData))]
        public void ShouldReturnCorrectResultWhenSolutionExists(TreeNode rootNode, string[] expectedResult)
        {
            var solution = new Solution();
            var actualResult = solution.BinaryTreePaths(rootNode);

            actualResult.ShouldEqual(expectedResult);
        }
    }
}
