using DSA.GetHandsDirty.LinkedListProblems;
using DSA.MyDataStructures;
using DSA.MyDataStructures.Abstractions;

namespace DSA.GetHandsDirty.UnitTests.LinkedListProblems;

public class ReverseBetweenTests
{
    private IMyLinkedList<int> intList;
    
    [Fact]
    public void Reverse_GivenAListOfIntegers_ShouldReverseTheMiddleOfTheList()
    {
        intList = new MyLinkedList<int>();
        intList
            .AddInLastPosition(1)
            .AddInLastPosition(2)
            .AddInLastPosition(3)
            .AddInLastPosition(4)
            .AddInLastPosition(5);
        var firstPosition = 2;
        var lastPosition = 4;
        var reversed = ReverseBetween<int>.Execute(intList.Head, firstPosition, lastPosition);

        var secondNode = reversed.Next;
        secondNode.ShouldNotBeNull();
        secondNode.Value.ShouldBe(4);
            
        var thirdNode = secondNode.Next;
        thirdNode.ShouldNotBeNull();
        thirdNode.Value.ShouldBe(3);
        
        var fourthNode = thirdNode.Next;
        fourthNode.ShouldNotBeNull();
        fourthNode.Value.ShouldBe(2);
    }
    
    [Fact]
    public void Reverse_GivenAnOneListItem_ShouldDoNothing()
    {
        intList = new MyLinkedList<int>();
        intList.AddInFirstPosition(5);
        var firstPosition = 1;
        var lastPosition = 1;
        var reversed = ReverseBetween<int>.Execute(intList.Head, firstPosition, lastPosition);
        reversed.ShouldNotBeNull();
        reversed.Value.ShouldBe(5);
    }
    
    [Fact]
    public void Reverse_GivenAListOfEightItems_ShouldReverseTheMiddleOfTheList()
    {
        intList = new MyLinkedList<int>();
        intList
            .AddInLastPosition(1)
            .AddInLastPosition(2)
            .AddInLastPosition(3)
            .AddInLastPosition(4)
            .AddInLastPosition(5)
            .AddInLastPosition(6)
            .AddInLastPosition(7)
            .AddInLastPosition(8);
        var firstPosition = 2;
        var lastPosition = 7;
        var reversed = ReverseBetween<int>.Execute(intList.Head, firstPosition, lastPosition);

        var secondNode = reversed.Next;
        secondNode.ShouldNotBeNull();
        secondNode.Value.ShouldBe(7);
            
        var thirdNode = secondNode.Next;
        thirdNode.ShouldNotBeNull();
        thirdNode.Value.ShouldBe(6);
        
        var fourthNode = thirdNode.Next;
        fourthNode.ShouldNotBeNull();
        fourthNode.Value.ShouldBe(5);
    }
}