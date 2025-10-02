using DSA.GetHandsDirty.LinkedListProblems;
using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.UnitTests.LinkedListProblems;

public class FindCircularReferenceTests
{
    [Fact]
    public void FindCircularReference_GivenALinkedListWithEnd_ShouldReturnFalse()
    {
        var list = new MyLinkedList<string>();
        list.AddInLastPosition("A");
        list.AddInLastPosition("B");
        list.AddInLastPosition("C");
        list.AddInLastPosition("D");
        list.AddInLastPosition("E");
        
        var result = FindCircularReference<string>.HasCycle(list.Head, out var steps);
        
        result.ShouldBeFalse();
        steps.ShouldBe(2); // The best case scenario should be O(n). Cresce proporcionalmente ao tamanho da lista;
    }
    
    [Fact]
    public void FindCircularReference_GivenACircularLinkedList_ShouldReturnTrue()
    {
        var nodeA = new MyNode<string>("A");
        var nodeB = new MyNode<string>("B");
        var nodeC = new MyNode<string>("C");
        var nodeD = new MyNode<string>("D");
        nodeA.Next = nodeB;
        nodeB.Next = nodeC;
        nodeC.Next = nodeD;
        nodeD.Next = nodeB;
        
        var result = FindCircularReference<string>.HasCycle(nodeA, out var steps);
        
        result.ShouldBeTrue();
        steps.ShouldBe(3);
    }
}