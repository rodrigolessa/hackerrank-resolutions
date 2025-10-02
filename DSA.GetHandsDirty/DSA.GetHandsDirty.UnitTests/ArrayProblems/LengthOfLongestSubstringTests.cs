using DSA.GetHandsDirty.ArrayProblems.StringProblems;

namespace DSA.GetHandsDirty.UnitTests.ArrayProblems;

public class LengthOfLongestSubstringTests
{
    [Fact]
    public void LengthOfLongestSubstring_GivenAValidString_ShouldReturnTheLengthOfLongestSubstring()
    {
        var result = LengthOfLongestSubstring.FindInOneIteration("abcabcbb");
        result.ShouldBe(3);
    }
    
    [Fact]
    public void FindWithMinimalOverhead_GivenAValidString_ShouldReturnTheLengthOfLongestSubstring()
    {
        var result = LengthOfLongestSubstring.FindWithMinimalOverhead("abcabcbb");
        result.ShouldBe(3);
    }
}