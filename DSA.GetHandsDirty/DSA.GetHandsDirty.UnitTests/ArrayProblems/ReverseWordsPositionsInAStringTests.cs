using DSA.GetHandsDirty.StringProblems;

namespace DSA.GetHandsDirty.UnitTests.ArrayProblems;

public class ReverseWordsPositionsInAStringTests
{
    [Fact]
    public void Reverse_GivenAValidStringWithFourWords_ShouldChangeThePositionAsExpected()
    {
        var input = "the sky is blue";
        var expected = "blue is sky the";
        var reversed = ReverseWordsPositionsInAString.Reverse(input);
        reversed.ShouldBe(expected);
    }

    [Fact]
    public void Reverse_GivenAStringWithBlankSpacesAtTheBeginningAndTheEnd_ShouldInvertAndRemoveTheSpaces()
    {
        var input = "  hello world  ";
        var expected = "world hello";
        var reversed = ReverseWordsPositionsInAString.Reverse(input);
        reversed.ShouldBe(expected);
    }

    [Fact]
    public void Reverse_GivenAStringWhitMoreThenOneBlankSpaceBetweenWords_ShouldReduceToASingleSpace()
    {
        var input = "a  good   example";
        var expected = "example good a";
        var reversed = ReverseWordsPositionsInAString.Reverse(input);
        reversed.ShouldBe(expected);
    }
}