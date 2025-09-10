using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.UnitTests.GraphProblems;

public class MyMinHeapTests
{
    [Fact]
    public void Insert_GivenAValidValues_ShouldInsertFollowingTheCorrectSequence()
    {
        var minHeap = new MyMinHeap<int>();
        minHeap.Insert(0);
        minHeap.Insert(1);
        minHeap.Insert(2);
        minHeap.Insert(3);
        minHeap.Insert(4);
        minHeap.Insert(5);
        minHeap.Insert(6);

        minHeap.ToArray().ShouldBe([0, 1, 2, 3, 4, 5, 6]);
    }

    [Fact]
    public void Insert_GivenARandomSequenceOfValidNumbers_ShouldInsertFollowingTheCorrectSequence()
    {
        var minHeap = GetMinHeap();
        minHeap.ToArray().ShouldBe([1, 2, 3, 5, 7, 9, 8, 10]);
    }

    [Fact]
    public void Pop_GivenAValidHeap_ShouldTheRootValue()
    {
        var minHeap = GetMinHeap();
        var rootValue = minHeap.Pop();
        rootValue.ShouldBe(1);
        minHeap.ToArray().ShouldBe([2, 5, 3, 10, 7, 9, 8]);
    }

    [Fact]
    public void Pop_GivenAHeapWhenLeftChildIsBiggerThanRight_ShouldReorganizeHeap()
    {
        var minHeap = new MyMinHeap<int>();
        minHeap.Insert(1);
        minHeap.Insert(3);
        minHeap.Insert(2);
        minHeap.Insert(7);
        minHeap.Insert(5);
        minHeap.Insert(9);
        minHeap.Insert(8);
        minHeap.Insert(10);
        minHeap.ToArray().ShouldBe([1, 3, 2, 7, 5, 9, 8, 10]);
        var rootValue = minHeap.Pop();
        rootValue.ShouldBe(1);
        minHeap.ToArray().ShouldBe([2, 3, 8, 7, 5, 9, 10]);
    }

    private MyMinHeap<int> GetMinHeap()
    {
        var minHeap = new MyMinHeap<int>();
        minHeap.Insert(5);
        minHeap.Insert(3);
        minHeap.Insert(2);
        minHeap.Insert(1);
        minHeap.Insert(7);
        minHeap.Insert(9);
        minHeap.Insert(8);
        minHeap.Insert(10);
        return minHeap;
    }
}