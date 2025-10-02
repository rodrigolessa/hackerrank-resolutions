using DSA.GetHandsDirty.StackProblems;

namespace DSA.GetHandsDirty.UnitTests.StackProblems;

public class DailyTemperaturesTests
{
    [Fact]
    public void DailyTemperatures_GivenAnArrayOfTemperatures_ShouldReturnTheDaysBeforeNextWarmerDay()
    {
        int[] temperatures = [73, 74, 75, 71, 69, 72, 76, 73];
        int[] expected = [1, 1, 4, 2, 1, 1, 0, 0];
        var solution = new DailyTemperaturesProblem();
        var days = solution.DailyTemperatures(temperatures);
        days.ShouldBe(expected);
    }

    [Fact]
    public void DailyTemperatures_GivenTemperaturesWithOneDayOfDistances_ShouldReturnTheDaysBeforeNextWarmerDay()
    {
        int[] temperatures = [30, 40, 50, 60];
        int[] expected = [1, 1, 1, 0];
        var solution = new DailyTemperaturesProblem();
        var days = solution.DailyTemperatures(temperatures);
        days.ShouldBe(expected);
    }

    [Fact]
    public void DailyTemperatures_GivenAnArrayOfHighTemperatures_ShouldReturnTheDaysBeforeNextWarmerDay()
    {
        int[] temperatures = [30, 60, 90];
        int[] expected = [1, 1, 0];
        var solution = new DailyTemperaturesProblem();
        var days = solution.DailyTemperatures(temperatures);
        days.ShouldBe(expected);
    }
}