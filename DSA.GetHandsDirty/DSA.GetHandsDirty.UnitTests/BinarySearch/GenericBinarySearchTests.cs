using DSA.GetHandsDirty.BinarySearch;
using FluentAssertions;

namespace DSA.GetHandsDirty.UnitTests.BinarySearch;

public class GenericBinarySearchTests
{
    [Theory]
    [InlineData(10, 8, 3)]
    [InlineData(50, 14, 4)]
    [InlineData(100, 56, 6)]
    public void GenericBinarySearch_GivenAnOrderedList_ShouldReturnTheRightPosition(
        int maxRange,
        int numberToFind,
        int expectedSteps)
    {
        const int initRange = 1;
        var numbers = Enumerable.Range(initRange, maxRange).ToArray();
        var result = GenericBinarySearch.Find(numbers, numberToFind, initRange, maxRange, out var steps);

        result.Should().Be(numberToFind - 1);
        steps.Should().Be(expectedSteps);
    }
}