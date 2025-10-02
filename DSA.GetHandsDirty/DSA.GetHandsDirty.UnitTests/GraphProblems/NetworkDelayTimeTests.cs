namespace DSA.GetHandsDirty.UnitTests.GraphProblems;

public class NetworkDelayTimeTests
{
    [Fact]
    public void FindTheMinimumTime_GivenFourNodesGraph_ShouldReturnTheMinTime()
    {
        int[][] times = [[2, 1, 1], [2, 3, 1], [3, 4, 1]];
        int n = 4;
        int k = 2;
        int expected = 2;
    }

    [Fact]
    public void FindTheMinimumTime_GivenTwoNodesGraph_ShouldReturnTheMinTime()
    {
        int[][] times = [[1, 2, 1]];
        int n = 2;
        int k = 1;
        int expected = 1;
    }

    [Fact]
    public void FindTheMinimumTime_GivenAnImpossibleSignalResponse_ShouldReturnMinusOne()
    {
        int[][] times = [[1, 2, 1]];
        int n = 2;
        int k = 2;
        int expected = -1;
    }
}