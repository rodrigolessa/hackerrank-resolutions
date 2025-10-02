using DSA.GetHandsDirty.BinaryOperationProblems;

namespace DSA.GetHandsDirty.UnitTests.BinaryOperationProblems;

public class NumberOfStepsToReduceToZeroTests
{
    [Theory]
    [InlineData(123,12)]
    [InlineData(14,6)]
    [InlineData(8,4)]
    public void NumberOfSteps_GivenAnInteger_ShouldReturnTheSteps(int num, int expectedSteps)
    {
        var steps = NumberOfStepsToReduceToZero.Reduce(num);
        steps.ShouldBe(expectedSteps);
    }
}