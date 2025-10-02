using DSA.GetHandsDirty.BinarySearch;
using DSA.GetHandsDirty.ExponentialSearch;
using Microsoft.VisualBasic.CompilerServices;

namespace DSA.GetHandsDirty.UnitTests.ExponentialSearch;

public class GenericExponentialSearchTests
{
    /// <summary>
    /// The performance is better than BinarySearch only because is more probable find the element at the beginning the array
    /// </summary>
    [Fact]
    public void Find_GivenAValidArrayOfNumbers_ShouldReturnTheRightPosition()
    {
        var numbers = Enumerable.Range(0, 10000).ToArray();
        var numberToFind = 14;
        var expectedSteps = 5;
        var position = GenericExponentialSearch.Find(numbers, numberToFind, out var steps);
        steps.ShouldBe(expectedSteps);
        position.ShouldBe(numberToFind);
    }
    
    [Fact]
    public void FindByBinarySearch_GivenAValidArrayOfNumbers_ShouldReturnTheRightPosition()
    {
        var numbers = Enumerable.Range(0, 10000).ToArray();
        var numberToFind = 14;
        var expectedSteps = 12;
        var position = GenericBinarySearch.Find(numbers, numberToFind, 0, numbers.Length - 1, out var steps);
        steps.ShouldBe(expectedSteps);
        position.ShouldBe(numberToFind);
    }
}