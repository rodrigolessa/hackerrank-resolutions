using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.UnitTests.StackProblems;

public class MyStackTests
{
    [Fact]
    public void Pop_GivenAStackWithThreeElements_ShouldReturnTheLastInserted()
    {
        var stack = new MyStack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        
        var lastValue =  stack.Pop();
        lastValue.ShouldBe(3);
        
        stack.Size().ShouldBe(2);
    }
}