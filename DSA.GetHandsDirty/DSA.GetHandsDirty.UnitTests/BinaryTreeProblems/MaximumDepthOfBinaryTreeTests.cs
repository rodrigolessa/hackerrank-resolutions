using DSA.GetHandsDirty.BinaryTreeProblems;

namespace DSA.GetHandsDirty.UnitTests.BinaryTreeProblems;

public class MaximumDepthOfBinaryTreeTests
{
    [Fact]
    public void MaxDepth_GivenAFourLevelTree_ShouldReturnNumberFour()
    {
        var maxDepth = new MaximumDepthOfBinaryTree();
        var tree = DummyData.GetMyFourLevelsBinaryTree(); 
        maxDepth.MaxDepth(tree.Root).ShouldBe(4);
    }
}