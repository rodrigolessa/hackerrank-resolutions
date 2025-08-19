using DSA.GetHandsDirty.BubbleSorte;

namespace DSA.GetHandsDirty.UnitTests.BubbleSort;

public class GenericBubbleSortTests
{
    [Theory]
    [MemberData(nameof(ShuffledArrayOfNumbers))]
    public void Sort_GivenAValidArrayOfIntegers_ShouldOrderNumerically(int[] nums, int[] expected)
    {
        GenericBubbleSort.Sort(nums);
        nums.ShouldBe(expected);
    }

    public static IEnumerable<object[]> ShuffledArrayOfNumbers()
    {
        yield return [new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 }];
        yield return [new int[] { 1, 4, 5, 2, 3 }, new int[] { 1, 2, 3, 4, 5 }];
        yield return [new int[] { 5, 3, 5, 1, 0 }, new int[] { 0, 1, 3, 5, 5 }];
        yield return [new int[] { 6, -1, 8, 2, 0, 1 }, new int[] { -1, 0, 1, 2, 6, 8 }];
        yield return [new int[] { 2, 2, 0, 1, 0, 1 }, new int[] { 0, 0, 1, 1, 2, 2 }];
    }
}