using DSA.GetHandsDirty.LinkedListProblems;
using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.UnitTests.LinkedListProblems;

public class MergeTwoListsTests
{
    [Fact]
    public void MergeAndSort_GivenAnEmptyListAndOtherWithOneElement_ShouldReturnTheSecondList()
    {
        var list1 = new MyLinkedList<int>();
        var list2 = new MyLinkedList<int>();
        list2.AddInFirstPosition(0);
        var outputNode = MergeTwoLists.MergeAndSort(list1.Head, list2.Head);
        outputNode.Value.ShouldBe(0);
    }
    
    [Fact]
    public void MergeAndSort_GivenTwoOrderedLists_ShouldReturnOneOrderedList()
    {
        var list1 = new MyLinkedList<int>();
        list1.AddInFirstPosition(4);
        list1.AddInFirstPosition(2);
        list1.AddInFirstPosition(1);
        var list2 = new MyLinkedList<int>();
        list2.AddInFirstPosition(4);
        list2.AddInFirstPosition(3);
        list2.AddInFirstPosition(1);
        
        var outputNode = MergeTwoLists.MergeAndSort(list1.Head, list2.Head);

        var arr = new int[6];
        var position = 0;
        var current = outputNode; 
        while (current.Next is not null)
        {
            arr[position] = current.Value;
            current = current.Next;
            position++;
        }
        
        arr[position] = current.Value;
        
        arr.ShouldBe([1,1,2,3,4,4]);
    }
    
    [Fact]
    public void MergeAndSort_TowEmptyLists_ShouldReturnAnEmptyNode()
    {
        var list1 = new MyLinkedList<int>();
        var list2 = new MyLinkedList<int>();
        var outputNode = MergeTwoLists.MergeAndSort(list1.Head, list2.Head);
        outputNode.ShouldBeNull();
    }
}