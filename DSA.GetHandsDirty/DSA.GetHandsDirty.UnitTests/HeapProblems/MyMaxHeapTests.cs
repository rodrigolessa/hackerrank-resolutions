using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.UnitTests.HeapProblems;

public class MyMaxHeapTests
{
    [Fact]
    public void Insert_GivenARandomSequenceOfValidNumbers_ShouldInsertFollowingTheCorrectSequence()
    {
        var heap = new MyMaxHeap<int>();
        heap.Insert(5);
        heap.Insert(3);
        heap.Insert(2);
        heap.Insert(1);
        heap.Insert(7);
        heap.Insert(9);
        heap.Insert(8);
        heap.Insert(10);

        heap.ToArray().ShouldBe([10, 9, 8, 5, 3, 2, 7, 1]);

        var root = heap.Pop();
        root.ShouldBe(10);

        heap.ToArray().ShouldBe([9, 5, 8, 1, 3, 2, 7]);
    }
}