using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.UnitTests.LinkedListProblems;

public class MyLinkedListTests
{
    [Fact]
    public void AddInFirstPosition_GivenAValidListOfStrings_ShouldReplaceTheHeadOfTheList()
    {
        var myList = new MyLinkedList<string>();
        myList.AddInFirstPosition("System");
        myList.AddInFirstPosition("Design");
        myList.AddInFirstPosition("Interview");
        myList.AddInFirstPosition("Home");
        myList.AddInFirstPosition("Task");

        myList.Head.ShouldNotBeNull();
        myList.Head.Value.ShouldBe("Task");
        
        myList.Tail.ShouldNotBeNull();
        myList.Tail.Value.ShouldBe("System");
    }
    
    [Fact]
    public void AddInLastPosition_GivenAValidListOfStrings_ShouldReplaceTheTailOfTheList()
    {
        var myList = new MyLinkedList<string>();
        myList.AddInLastPosition("System");
        myList.AddInLastPosition("Design");
        myList.AddInLastPosition("Interview");

        myList.Head.ShouldNotBeNull();
        myList.Head.Value.ShouldBe("System");
        
        myList.Tail.ShouldNotBeNull();
        myList.Tail.Value.ShouldBe("Interview");
    }
    
    [Fact]
    public void RemoveFirstPosition_GivenAValidListOfIntegers_ShouldRemoveAndReturnTheHeadValue()
    {
        var myList = new MyLinkedList<short>();
        for (short n = 1; n < 10; n++)
            myList.AddInLastPosition(n);

        myList.HowMany().ShouldBe(9);
        var firstNumber = myList.RemoveFirstPosition();
        firstNumber.ShouldBe((short)1);

        myList.Head.ShouldNotBeNull();
        myList.Head.Value.ShouldBe((short)2);
        
        myList.HowMany().ShouldBe(8);
        myList.Tail.ShouldNotBeNull();
        myList.Tail.Value.ShouldBe((short)9);
    }
    
    [Fact]
    public void RemoveLastPosition_GivenAValidListOfDecimals_ShouldRemoveAndReturnTheTailValue()
    {
        var myList = new MyLinkedList<decimal>();
        for (var d = 10.9m; d > 10m; d -= 0.1m)
            myList.AddInFirstPosition(d);
        
        myList.HowMany().ShouldBe(9);
        var lastNumber = myList.RemoveLastPosition();
        
        lastNumber.ShouldBe(10.9m);

        myList.Head.ShouldNotBeNull();
        myList.Head.Value.ShouldBe(10.1m);
        
        myList.HowMany().ShouldBe(8);
        myList.Tail.ShouldNotBeNull();
        myList.Tail.Value.ShouldBe(10.8m);
    }
    
    [Fact]
    public void Reverse_GivenAValidListOfStrings_ShouldInvertThePositionOfEveryNodeInTheList()
    {
        var myList = new MyLinkedList<string>();
        myList.AddInFirstPosition("System");
        myList.AddInFirstPosition("Design");
        myList.AddInFirstPosition("Interview");
        myList.AddInFirstPosition("Home");
        myList.AddInFirstPosition("Task");
        
        myList.Reverse();

        myList.Head.ShouldNotBeNull();
        myList.Head.Value.ShouldBe("System");
    }
}