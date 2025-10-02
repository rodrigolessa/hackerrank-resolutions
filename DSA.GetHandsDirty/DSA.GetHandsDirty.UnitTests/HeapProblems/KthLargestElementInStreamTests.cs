using DSA.GetHandsDirty.HeapProblems;

namespace DSA.GetHandsDirty.UnitTests.HeapProblems;

public class KthLargestElementInStreamTests
{
    [Fact]
    public void KthLargest_GivenASortedListOfScores_ShouldReturnTheCutOffMark()
    {
        var kthLargest = new KthLargestElementInStream(3, [4, 5, 8, 2]);
        var cutOffMark = kthLargest.Add(3);
        cutOffMark.ShouldBe(4);

        cutOffMark = kthLargest.Add(5);
        cutOffMark.ShouldBe(5);

        cutOffMark = kthLargest.Add(10);
        cutOffMark.ShouldBe(5);

        cutOffMark = kthLargest.Add(9);
        cutOffMark.ShouldBe(8);

        cutOffMark = kthLargest.Add(4);
        cutOffMark.ShouldBe(8);
    }
    
    [Fact]
    public void KthLargest_GivenASortedListOfScoresLimitedToFourHigherScores_ShouldReturnTheCutOffMark()
    {
        var kthLargest = new KthLargestElementInStream(4, [7, 7, 7, 7, 8, 3]);
        var cutOffMark = kthLargest.Add(2);
        cutOffMark.ShouldBe(7);

        cutOffMark = kthLargest.Add(10);
        cutOffMark.ShouldBe(7);

        cutOffMark = kthLargest.Add(9);
        cutOffMark.ShouldBe(7);

        cutOffMark = kthLargest.Add(9);
        cutOffMark.ShouldBe(8);
    }
}