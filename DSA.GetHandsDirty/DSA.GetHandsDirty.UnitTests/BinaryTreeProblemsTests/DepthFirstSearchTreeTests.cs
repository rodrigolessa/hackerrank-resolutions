using DSA.GetHandsDirty.BinaryTreeProblems;
using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.UnitTests.BinaryTreeProblemsTests;

public class DepthFirstSearchTreeTests
{
    private readonly MyBinaryTree _tree;

    public DepthFirstSearchTreeTests()
    {
        _tree = new MyBinaryTree();
        _tree.Insert(5);
        _tree.Insert(7);
        _tree.Insert(9);
        _tree.Insert(3);
        _tree.Insert(10);
        _tree.Insert(2);
        _tree.Insert(1);
        _tree.Insert(8);
    }
    
    [Theory]
    [InlineData(29, true)]
    [InlineData(31, true)]
    [InlineData(11, true)]
    [InlineData(21, false)]
    public void HasPathSum_GivenAValidTreeWithCorrectPathSum_ShouldReturnTrue(int targetSum, bool expected)
    {
        var dfs = new DepthFirstSearchTree();
        var hasSum = dfs.HasPathSum(_tree.Root, targetSum);
        hasSum.ShouldBe(expected);
    }
}