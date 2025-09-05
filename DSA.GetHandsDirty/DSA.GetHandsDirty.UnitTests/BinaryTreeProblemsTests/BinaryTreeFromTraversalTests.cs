using DSA.GetHandsDirty.BinaryTreeProblems;
using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.UnitTests.BinaryTreeProblemsTests;

public class BinaryTreeFromTraversalTests
{
    [Fact]
    public void Insert_GivenAValidIntegerSequence_ShouldDistributeCorrectly()
    {
        int[] inorder = [1, 2, 3, 5, 7, 8, 9, 10];
        int[] postorder = [1, 2, 3, 8, 10, 9, 7, 5];

        var traversal = new BinaryTreeFromTraversal();

        var treeRoot = traversal.BuildTree(inorder, postorder);
        treeRoot.Data.ShouldBe(5);
        treeRoot.RightChild?.Data.ShouldBe(7);
        treeRoot.RightChild?.RightChild?.Data.ShouldBe(9);
        treeRoot.RightChild?.RightChild?.LeftChild?.Data.ShouldBe(8);
        treeRoot.LeftChild?.Data.ShouldBe(3);
    }
}