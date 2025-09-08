using DSA.GetHandsDirty.BinaryTreeProblems;
using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.UnitTests.BinaryTreeProblemsTests;

public class SameTreeProblemTests
{
    [Fact]
    public void IsSameTree_GivenAnIdenticalTrees_ShouldReturnTrue()
    {
        var a = new MyBinaryTree();
        var b = new MyBinaryTree();
        
        a.Insert(1);
        b.Insert(1);
        a.Insert(2);
        b.Insert(2);
        a.Insert(3);
        b.Insert(3);
        
        var sameTreeProblem = new SameTreeProblem();
        sameTreeProblem.IsSameTree(a.Root, b.Root).ShouldBeTrue();
    }
    
    [Fact]
    public void IsSameTree_GivenTwoDifferentTrees_ShouldReturnTrue()
    {
        var a = new MyBinaryTree();
        var b = new MyBinaryTree();
        
        a.Insert(1);
        b.Insert(1);
        a.Insert(2);
        b.Insert(1);
        a.Insert(3);
        b.Insert(3);
        
        var sameTreeProblem = new SameTreeProblem();
        sameTreeProblem.IsSameTree(a.Root, b.Root).ShouldBeFalse();
    }
}