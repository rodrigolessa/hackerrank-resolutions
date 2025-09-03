namespace DSA.MyDataStructures.UnitTests;

public class MyBinaryTreeTests
{
    private readonly MyBinaryTree _tree;

    public MyBinaryTreeTests()
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

    [Fact]
    public void Insert_GivenAValidIntegerSequence_ShouldDistributeCorrectly()
    {
        _tree.Root.Data.ShouldBe(5);
        _tree.Root.RightChild?.Data.ShouldBe(7);
        _tree.Root.RightChild?.RightChild?.Data.ShouldBe(9);
        _tree.Root.RightChild?.RightChild?.LeftChild?.Data.ShouldBe(8);
        _tree.Root.LeftChild?.Data.ShouldBe(3);
    }

    [Theory]
    [InlineData(5, true)]
    [InlineData(9, true)]
    [InlineData(4, false)]
    public void Search_GivenAValidInteger_ShouldReturnIfExists(int n, bool expected)
    {
        var node = _tree.Search(n);
        ((node is not null) == expected).ShouldBeTrue();
    }
    
    
    [Fact]
    public void PreorderTraversal_GivenAValidBalanceTree_ShouldReturnAnArrayFromRootToLastAtRightmostPosition()
    {
        var rootAtTheBeginning = _tree.PreorderTraversal();
        rootAtTheBeginning.ShouldBe([5,3,2,1,7,9,8,10]);
    }
    
    [Fact]
    public void InorderTraversal_GivenAValidBalanceTree_ShouldReturnAnArrayWhereRootIsAtTheMiddle()
    {
        var inorder = _tree.InorderTraversal();
        inorder.ShouldBe([1,2,3,5,7,8,9,10]);
    }
    
    [Fact]
    public void PostorderTraversal_GivenAValidBalanceTree_ShouldReturnAnArrayWhereTheLastElementIsTheRoot()
    {
        var result = _tree.PostOrderTraversal();
        result.ShouldBe([1,2,3,8,10,9,7,5]);
    }
}