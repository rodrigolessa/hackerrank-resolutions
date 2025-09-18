using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.UnitTests.StackProblems;

public class MyMinStackTests
{
    [Fact]
    public void GetMin_GivenASequenceOfValidOperationOfPushAndPop_UsingGetMin_ShouldReturnTheMinimunValueLeft()
    {
        var obj = new MyMinStack();
        obj.Push(-2);
        obj.Push(0);
        obj.Push(-3);
        obj.Pop();
        obj.Top().ShouldBe(0);
        obj.GetMin().ShouldBe(-2);
    }
}