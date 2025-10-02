using DSA.GetHandsDirty.SlidingWindow;

namespace DSA.GetHandsDirty.UnitTests.SlindingWindow;

public class FindSequenceThatDoesNotRepeatTests
{
    [Fact]
    public void Find_GivenASequenceOfLetters_ShouldCountTheLongestSequence()
    {
        var input = "abbcdeeedcbaaccd";
        var expected = 5;
        var longestSequence = FindSequenceThatDoesNotRepeat.Find(input, 1);
        longestSequence.ShouldBe(expected);
    }
    
    [Fact]
    public void Find_GivenASequenceOfLetters_ShouldReturnTheMaximumLengthSubstringWithTwoOccurrences()
    {
        var input = "bcbbbcba";
        var expected = 4;
        var longestSequence = FindSequenceThatDoesNotRepeat.Find(input, 2);
        longestSequence.ShouldBe(expected);
    }
}