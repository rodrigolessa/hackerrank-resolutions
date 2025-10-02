namespace DSA.GetHandsDirty.UnitTests.BinaryTreeProblems;

public class BinaryTreeTraversalsTests
{
    [Fact]
    public void PreorderTraversal_GivenAValidBalanceTree_ShouldReturnAnArrayFromRootToLastAtRightmostPosition()
    {
        var tree = DummyData.GetMyFourLevelsBinaryTree();
        var rootAtTheBeginning = tree.PreorderTraversal();
        rootAtTheBeginning.ShouldBe([5,3,2,1,7,9,8,10]);
    }
    
    [Fact]
    public void InorderTraversal_GivenAValidBalanceTree_ShouldReturnAnArrayWhereRootIsAtTheMiddle()
    {
        var tree = DummyData.GetMyFourLevelsBinaryTree();
        var inorder = tree.InorderTraversal();
        inorder.ShouldBe([1,2,3,5,7,8,9,10]);
    }
    
    [Fact]
    public void PostorderTraversal_GivenAValidBalanceTree_ShouldReturnAnArrayWhereTheLastElementIsTheRoot()
    {
        var tree = DummyData.GetMyFourLevelsBinaryTree();
        var result = tree.PostOrderTraversal();
        result.ShouldBe([1,2,3,8,10,9,7,5]);
    }
}