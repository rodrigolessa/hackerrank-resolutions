using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.UnitTests.BinaryTreeProblems;

public class BinaryTreeSearchTests
{
    [Theory]
    [InlineData(5, true)]
    [InlineData(9, true)]
    [InlineData(4, false)]
    public void Search_GivenAValidInteger_ShouldReturnIfExists(int n, bool expected)
    {
        var tree = new MyBinaryTree();
        tree.Insert(5);
        tree.Insert(7);
        tree.Insert(9);
        tree.Insert(3);
        var node = tree.Search(n);
        ((node is not null) == expected).ShouldBeTrue();
    }
    
    [Theory]
    [InlineData(5, true)]
    [InlineData(9, true)]
    [InlineData(4, false)]
    public void SearchRecursively_GivenAValidInteger_ShouldReturnIfExists(int n, bool expected)
    {
        var root = DummyData.GetMyFourLevelsBinaryTree().Root;
        var node = MyBinaryTree.Search(n, root);
        ((node is not null) == expected).ShouldBeTrue();
    }
}