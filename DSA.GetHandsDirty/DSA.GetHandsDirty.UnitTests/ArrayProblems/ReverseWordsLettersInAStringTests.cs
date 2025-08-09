using DSA.GetHandsDirty.ArrayProblems.StringProblems;

namespace DSA.GetHandsDirty.UnitTests.ArrayProblems;

public class ReverseWordsLettersInAStringTests
{
    [Fact]
    public void Reverse_GivenAValidString_ShouldReverseAllLetters()
    {
        var input = "The quick brown fox";
        var expected = "ehT kciuq nworb xof";
        var reversed = ReverseWordsLettersInAString.Reverse(input);
        reversed.ShouldBe(expected);
    }
}