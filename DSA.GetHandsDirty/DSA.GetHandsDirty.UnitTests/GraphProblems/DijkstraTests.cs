using DSA.GetHandsDirty.GraphProblems;

namespace DSA.GetHandsDirty.UnitTests.GraphProblems;

public class DijkstraTests
{
    [Fact]
    public void FindShortestDistance_GivenAValidGraphWithWeightsBetweenNeighbors_ShouldReturnTheShortestPath()
    {
        Dictionary<string, List<(string neighbor, int weight)>> graph =
            new Dictionary<string, List<(string neighbor, int weight)>>
            {
                { "A", [("B", 1), ("C", 4)] },
                { "B", [("A", 1), ("C", 2), ("D", 5)] },
                { "C", [("A", 4), ("B", 2), ("D", 1)] },
                { "D", [("B", 5), ("C", 1)] }
            };

        var expected = new Dictionary<string, int>
        {
            { "A", 0 }, { "B", 1 }, { "C", 3 }, { "D", 4 }
        };

        var solution = new Dijkstra();
        var result = solution.FindShortestDistance(graph, "A");

        result.ShouldBe(expected);
    }
}