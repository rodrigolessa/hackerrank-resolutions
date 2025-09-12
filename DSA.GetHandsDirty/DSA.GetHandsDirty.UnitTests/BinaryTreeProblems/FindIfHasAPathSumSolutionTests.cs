using DSA.GetHandsDirty.BinaryTreeProblems.Search.DepthFirstSearch;

namespace DSA.GetHandsDirty.UnitTests.BinaryTreeProblems;

public class FindIfHasAPathSumSolutionTests
{
    [Theory]
    [InlineData(29, true)]
    [InlineData(31, true)]
    [InlineData(11, true)]
    [InlineData(21, false)]
    public void HasPathSum_GivenAValidTreeWithCorrectPathSum_ShouldReturnTrue(int targetSum, bool expected)
    {
        var dfs = new FindIfHasAPathSumSolution();
        var treeRoot = DummyData.GetMyFourLevelsBinaryTree().Root;
        var hasSum = dfs.HasPathSum(treeRoot, targetSum);
        hasSum.ShouldBe(expected);
    }
}