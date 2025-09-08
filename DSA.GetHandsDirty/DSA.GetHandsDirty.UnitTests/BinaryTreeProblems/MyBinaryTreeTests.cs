namespace DSA.GetHandsDirty.UnitTests.BinaryTreeProblems;

public class MyBinaryTreeTests
{
    [Fact]
    public void Insert_GivenAValidIntegerSequence_ShouldDistributeCorrectly()
    {
        var tree = DummyData.GetMyFourLevelsBinaryTree();
        tree.Root.Data.ShouldBe(5);
        tree.Root.RightChild?.Data.ShouldBe(7);
        tree.Root.RightChild?.RightChild?.Data.ShouldBe(9);
        tree.Root.RightChild?.RightChild?.LeftChild?.Data.ShouldBe(8);
        tree.Root.LeftChild?.Data.ShouldBe(3);
    }
}