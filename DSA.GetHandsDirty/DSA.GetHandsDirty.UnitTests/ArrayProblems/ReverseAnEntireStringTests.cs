using DSA.GetHandsDirty.StringProblems;

namespace DSA.GetHandsDirty.UnitTests.ArrayProblems;

public class ReverseAnEntireStringTests
{
    [Fact]
    public void Reverse_GivenAValidString_ShouldReverseAllLetters()
    {
        var input = "The quick brown fox jumps over the lazy dog";
        var expected = "god yzal eht revo spmuj xof nworb kciuq ehT";
        var reversed = ReverseAnEntireString.Reverse(input);
        reversed.ShouldBe(expected);
    }
}