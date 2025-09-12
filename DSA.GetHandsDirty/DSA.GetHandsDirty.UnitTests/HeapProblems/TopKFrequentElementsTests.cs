using DSA.GetHandsDirty.HeapProblems;

namespace DSA.GetHandsDirty.UnitTests.HeapProblems;

public class TopKFrequentElementsTests
{
    private readonly TopKFrequentElements _solution = new();

    [Fact]
    public void TopKFrequent_GivenAnOrderedArray_ShouldReturnTheTwoFrequentElements()
    {
        int[] nums = [1, 1, 1, 2, 2, 3];
        int k = 2;
        int[] expected = [1, 2];
        var result = _solution.TopKFrequent(nums, k);
        result.ShouldBe(expected);
    }

    [Fact]
    public void TopKFrequent_GivenAnOneValueArray_ShouldReturnTheOnlyElement()
    {
        int[] nums = [1];
        int k = 1;
        int[] expected = [1];
        var result = _solution.TopKFrequent(nums, k);
        result.ShouldBe(expected);
    }

    [Fact]
    public void TopKFrequent_GivenAValidArray_ShouldReturnTheTwoFrequentElements()
    {
        int[] nums = [1, 2, 1, 2, 1, 2, 3, 1, 3, 2];
        int k = 2;
        int[] expected = [1, 2];
        var result = _solution.TopKFrequent(nums, k);
        result.ShouldBe(expected);
    }
}