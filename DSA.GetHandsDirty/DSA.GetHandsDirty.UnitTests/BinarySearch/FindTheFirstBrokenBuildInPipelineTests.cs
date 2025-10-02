using DSA.GetHandsDirty.BinarySearch;

namespace DSA.GetHandsDirty.UnitTests.BinarySearch;

public class FindTheFirstBrokenBuildInPipelineTests
{
    [Theory]
    [InlineData(10, 1008, 4)]
    [InlineData(50, 1015, 6)]
    [InlineData(100, 1055, 7)]
    public void FindFirstBrokenBuild_GivenAnOrderedListOfBuildNumbers_ShouldReturnTheFirstBrokenBuildAndTheNumberOfSteps(
        int maxRange,
        int firstBrokenBuild,
        int expectedSteps)
    {
        var builds = Enumerable.Range(1001, maxRange).ToArray();
        var result = FindTheFirstBrokenBuildInPipeline.Find(builds, buildId => buildId >= firstBrokenBuild, out var steps);

        result.ShouldBe(firstBrokenBuild);
        steps.ShouldBe(expectedSteps);
    }
}