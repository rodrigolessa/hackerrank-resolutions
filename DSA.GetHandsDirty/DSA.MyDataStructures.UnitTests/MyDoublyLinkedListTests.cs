namespace DSA.MyDataStructures.UnitTests;

public class MyDoublyLinkedListTests
{   
    [Fact]
    public void AddInFirstPosition_GivenAValidListOfStrings_ShouldReplaceTheHeadOfTheList()
    {
        var myList = new MyDoublyLinkedList<string>();
        myList.InsertAtTheBeginning("System");
        myList.InsertAtTheBeginning("Design");
        myList.InsertAtTheBeginning("Interview");
        myList.InsertAtTheBeginning("Home");
        myList.InsertAtTheBeginning("Task");

        myList.Head.ShouldNotBeNull();
        myList.Head.Value.ShouldBe("Task");

        myList.Tail.ShouldNotBeNull();
        myList.Tail.Value.ShouldBe("System");
    }

    [Fact]
    public void AddInLastPosition_GivenAValidListOfStrings_ShouldReplaceTheTailOfTheList()
    {
        var myList = new MyDoublyLinkedList<string>();
        myList.InsertAtTheEnd("System");
        myList.InsertAtTheEnd("Design");
        myList.InsertAtTheEnd("Interview");

        myList.Head.ShouldNotBeNull();
        myList.Head.Value.ShouldBe("System");

        myList.Tail.ShouldNotBeNull();
        myList.Tail.Value.ShouldBe("Interview");
    }

    [Fact]
    public void RemoveFirstPosition_GivenAValidListOfIntegers_ShouldRemoveAndReturnTheHeadValue()
    {
        var myList = new MyDoublyLinkedList<short>();
        for (short n = 1; n < 10; n++)
            myList.InsertAtTheEnd(n);

        var firstNumber = myList.TakeFromTheBeginning();
        firstNumber.ShouldBe((short)1);

        myList.Head.ShouldNotBeNull();
        myList.Head.Value.ShouldBe((short)2);

        myList.Tail.ShouldNotBeNull();
        myList.Tail.Value.ShouldBe((short)9);
    }

    [Fact]
    public void RemoveLastPosition_GivenAValidListOfDecimals_ShouldRemoveAndReturnTheTailValue()
    {
        var myList = new MyDoublyLinkedList<decimal>();
        for (var d = 10.9m; d > 10m; d -= 0.1m)
            myList.InsertAtTheBeginning(d);

        var lastNumber = myList.TakeFromTheEnd();

        lastNumber.ShouldBe(10.9m);

        myList.Head.ShouldNotBeNull();
        myList.Head.Value.ShouldBe(10.1m);

        myList.Tail.ShouldNotBeNull();
        myList.Tail.Value.ShouldBe(10.8m);
    }
}