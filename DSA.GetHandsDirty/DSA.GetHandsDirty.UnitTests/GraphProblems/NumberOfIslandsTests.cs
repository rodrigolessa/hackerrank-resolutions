using DSA.GetHandsDirty.GraphProblems;

namespace DSA.GetHandsDirty.UnitTests.GraphProblems;

public class NumberOfIslandsTests
{
    [Fact]
    public void NumInslands_GivenAValidMatrixWithLandsConnected_ShouldReturnOneIsland()
    {
        char[][] grid =
        [
            ['1', '1', '1', '1', '0'], ['1', '1', '0', '1', '0'], ['1', '1', '0', '0', '0'], ['0', '0', '0', '0', '0']
        ];
        var solution = new NumberOfIslands();
        var number = solution.NumIslands(grid);
        number.ShouldBe(1);
    }

    [Fact]
    public void NumInslands_GivenAValidMatrixWithLandsDisconnected_ShouldReturnThree()
    {
        char[][] grid =
        [
            ['1', '1', '0', '0', '0'], ['1', '1', '0', '0', '0'], ['0', '0', '1', '0', '0'], ['0', '0', '0', '1', '1']
        ];
        var solution = new NumberOfIslands();
        var number = solution.NumIslands(grid);
        number.ShouldBe(3);
    }
}