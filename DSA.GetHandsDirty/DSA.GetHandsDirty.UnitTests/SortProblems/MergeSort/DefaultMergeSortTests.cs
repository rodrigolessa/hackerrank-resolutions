using DSA.GetHandsDirty.LinkedListProblems;
using DSA.GetHandsDirty.SortProblems.MergeSort;
using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.UnitTests.SortProblems.MergeSort;

public class DefaultMergeSortTests
{
    [Fact]
    public void Sort_GivenAValidLinkedList_ShouldAnOrderedList()
    {
        var myList = new MyLinkedList<int>();
        myList.AddInFirstPosition(10);
        myList.AddInFirstPosition(2);
        myList.AddInFirstPosition(5);
        myList.AddInFirstPosition(11);
        myList.AddInFirstPosition(3);
        myList.AddInFirstPosition(4);
        myList.AddInFirstPosition(0);
        myList.AddInFirstPosition(7);
        myList.AddInFirstPosition(8);

        var orderedList = IntegerMergeSort.Sort(myList.Head);

        var arr = new int[9];
        var position = 0;
        var current = orderedList; 
        while (current.Next is not null)
        {
            arr[position] = current.Value;
            current = current.Next;
            position++;
        }
        
        arr[position] = current.Value;
        
        arr.ShouldBe([0,2,3,4,5,7,8,10,11]);
    }
}