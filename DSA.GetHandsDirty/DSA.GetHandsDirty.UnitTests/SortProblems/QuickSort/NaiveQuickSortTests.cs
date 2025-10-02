using DSA.GetHandsDirty.SortProblems.QuickSort;

namespace DSA.GetHandsDirty.UnitTests.SortProblems.QuickSort;

public class NaiveQuickSortTests
{
    [Fact]
    public void SortSubArray_GivenADisorderlyArrayOfNumbers_ShouldOrderNumerically()
    {
        int[] arr = [1, 0, 9, 6, 4, 3, 2, 8, 7, 5];
        NaiveQuickSort.NaiveSort(arr, 0, arr.Length - 1);
        arr.ShouldBe([0, 1, 2, 3, 4, 5, 6, 7, 8, 9]);
    }

    [Fact]
    public void SortSubArray_GivenADisorderlyArrayWithDuplicateNumbers_ShouldOrderNumerically()
    {
        int[] numbers = [34, 7, 23, 32, 5, 62, 32, 7, 4, 1];
        NaiveQuickSort.NaiveSort(numbers, 0, numbers.Length - 1);
        numbers.ShouldBe([1, 4, 5, 7, 7, 23, 32, 32, 34, 62]);
    }
    
    [Fact]
    public void SortRandomly_GivenADisorderlyArrayOfNumbers_ShouldOrderNumerically()
    {
        int[] numbers = [1, 0, 9, 6, 4, 3, 8, 2, 7, 5];
        RandomQuickSort.SortRandomly(numbers, 0, numbers.Length - 1);
        numbers.ShouldBe([0, 1, 2, 3, 4, 5, 6, 7, 8, 9]);
    }

    [Fact]
    public void SortRandomly_GivenADisorderlyArrayWithDuplicateNumbers_ShouldOrderNumerically()
    {
        int[] numbers = [34, 7, 23, 32, 5, 62, 32, 7, 4, 1];
        RandomQuickSort.SortRandomly(numbers, 0, numbers.Length - 1);
        numbers.ShouldBe([1, 4, 5, 7, 7, 23, 32, 32, 34, 62]);
    }
}