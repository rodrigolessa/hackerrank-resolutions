using DSA.GetHandsDirty.BinaryTreeProblems;

namespace DSA.GetHandsDirty.UnitTests.BinaryTreeProblems;

public class BinaryTreeOrderLevelTraversalTests
{
    [Fact]
    public void LevelOrder_GivenAValidTreeWithFourLevels_ShouldReturnTheRespectiveArray()
    {
        var levelTraversal = new BinaryTreeOrderLevelTraversal();
        var treeRoot = DummyData.GetMyFourLevelsBinaryTree().Root;
        var allLevels = levelTraversal.LevelOrder(treeRoot);
        allLevels.ShouldBe([[5], [3, 7], [2, 9], [1, 8, 10]]);
    }
}