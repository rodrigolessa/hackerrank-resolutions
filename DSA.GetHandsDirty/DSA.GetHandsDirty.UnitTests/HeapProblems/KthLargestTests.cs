using DSA.GetHandsDirty.HeapProblems;

namespace DSA.GetHandsDirty.UnitTests.HeapProblems;

public class KthLargestTests
{
    [Fact]
    public void KthLargest_GivenASortedListOfScores_ShouldReturnTheCutOffMark()
    {
        var largestScores = new KthLargest(3, [4, 5, 8, 2]);
        var cutOffMark = largestScores.Add(3);
        cutOffMark.ShouldBe(4);

        cutOffMark = largestScores.Add(5);
        cutOffMark.ShouldBe(5);

        cutOffMark = largestScores.Add(10);
        cutOffMark.ShouldBe(5);

        cutOffMark = largestScores.Add(9);
        cutOffMark.ShouldBe(8);

        cutOffMark = largestScores.Add(4);
        cutOffMark.ShouldBe(8);
    }
}