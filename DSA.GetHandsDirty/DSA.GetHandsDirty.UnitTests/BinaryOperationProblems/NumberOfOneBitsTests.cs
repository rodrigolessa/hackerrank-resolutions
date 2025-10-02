using DSA.GetHandsDirty.BinaryOperationProblems;

namespace DSA.GetHandsDirty.UnitTests.BinaryOperationProblems;

public class NumberOfOneBitsTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(11, 3)]
    [InlineData(128, 1)]
    [InlineData(2147483645, 30)]
    public void HammingWeight_GivenAValidPositiveInteger_ShouldReturnTheNumbersOfOneBits(int n, int expected)
    {
        var hammingWeight = NumberOfOneBits.HammingWeight(n);
        hammingWeight.ShouldBe(expected);
    }

    [Fact]
    public void CountingOneBits_GivenTheNumberTwo_ShouldReturnAnArrayOfOneBits()
    {
        var n = 2;
        int[] output = [0, 1, 1];
        var arr = NumberOfOneBits.CountingOneBits(n);
        arr.ShouldBe(output);
    }
    
    [Fact]
    public void CountingOneBits_GivenAValidPositiveInteger_ShouldReturnAnArrayOfOneBits()
    {
        var n = 5;
        int[] output = [0, 1, 1, 2, 1, 2];
        var arr = NumberOfOneBits.CountingOneBits(n);
        arr.ShouldBe(output);
    }
}