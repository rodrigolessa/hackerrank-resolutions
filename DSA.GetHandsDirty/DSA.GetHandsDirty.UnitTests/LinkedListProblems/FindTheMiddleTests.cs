using DSA.GetHandsDirty.LinkedListProblems;
using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.UnitTests.LinkedListProblems;

public class FindTheMiddleTests
{
    [Fact]
    public void FindTheMiddle_GivenAValidLinkedList_ShouldReturnTheValueAtTheMiddleOfTheList()
    {
        var myList = new MyLinkedList<int>();
        myList.AddInFirstPosition(9);
        myList.AddInFirstPosition(8);
        myList.AddInFirstPosition(7);
        myList.AddInFirstPosition(6);
        myList.AddInFirstPosition(5);
        myList.AddInFirstPosition(4);
        myList.AddInFirstPosition(3);
        myList.AddInFirstPosition(2);
        myList.AddInFirstPosition(1);

        var valueAtTheMiddle = FindTheMiddle<int>.Find(myList.Head);
        valueAtTheMiddle.ShouldBe(5);
    }
    
    [Fact]
    public void FindTheMiddle_GivenALinkedWithAPairNumberOfElements_ShouldReturnTheValueAtTheMiddleOfTheList()
    {
        var myList = new MyLinkedList<int>();
        myList.AddInFirstPosition(8);
        myList.AddInFirstPosition(7);
        myList.AddInFirstPosition(6);
        myList.AddInFirstPosition(5);

        var valueAtTheMiddle = FindTheMiddle<int>.Find(myList.Head);
        valueAtTheMiddle.ShouldBe(7);
    }
}