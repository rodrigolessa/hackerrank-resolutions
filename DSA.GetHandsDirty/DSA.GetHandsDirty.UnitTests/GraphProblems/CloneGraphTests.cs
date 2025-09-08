using DSA.GetHandsDirty.GraphProblems;
using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.UnitTests.GraphProblems;

public class CloneGraphTests
{
    [Fact]
    public void Clone_GivenAFourNodesEachWithTwoNeighbors_ShouldReturnTheSameStructure()
    {
        var nodeOne = new MyGraphNode(1);
        var nodeTwo = new MyGraphNode(2);
        var nodeThree = new MyGraphNode(3);
        var nodeFour = new MyGraphNode(4);
        
        nodeOne.neighbors.Add(nodeTwo);
        nodeOne.neighbors.Add(nodeFour);
        
        nodeTwo.neighbors.Add(nodeOne);
        nodeTwo.neighbors.Add(nodeThree);
        
        nodeThree.neighbors.Add(nodeTwo);
        nodeThree.neighbors.Add(nodeFour);
        
        nodeFour.neighbors.Add(nodeOne);
        nodeFour.neighbors.Add(nodeThree);
        
        var f = new CloneGraph();
        var clone = f.Clone(nodeOne);
        
        clone.val.ShouldBe(1);
        clone.neighbors.Count.ShouldBe(2);
        clone.neighbors[0].val.ShouldBe(2);
        clone.neighbors[1].val.ShouldBe(4);
    }
}