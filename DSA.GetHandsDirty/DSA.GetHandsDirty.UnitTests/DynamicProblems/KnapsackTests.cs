using DSA.GetHandsDirty.DynamicProgrammingTechnique;

namespace DSA.GetHandsDirty.UnitTests.DynamicProblems;

public class KnapsackTests
{
    [Fact]
    public void CoinChange_GivenAValidValuesForCoins_ShouldReturnTheBastCombination()
    {
        int[] coins = [1, 2, 5];
        int amount = 11;
        var solution = new KnapsackProblem();
        var result = solution.CoinChange(coins, amount);
        result.ShouldBe(3);
    }

    [Fact]
    public void CoinChange_GivenAnInvalidCoinsToTheAmount_ShouldReturnDefaultValue()
    {
        int[] coins = [2];
        int amount = 3;
        var solution = new KnapsackProblem();
        var result = solution.CoinChange(coins, amount);
        result.ShouldBe(-1);
    }

    [Fact]
    public void CoinChange_GivenAZeroAmount_ShouldReturnZeroCombinations()
    {
        int[] coins = [1];
        int amount = 0;
        var solution = new KnapsackProblem();
        var result = solution.CoinChange(coins, amount);
        result.ShouldBe(0);
    }
    [Fact]
    public void CoinChange_GivenANotOrderedCoins_ShouldReturnAsExpected()
    {
        int[] coins = [2,5,10,1];
        int amount = 27;
        var solution = new KnapsackProblem();
        var result = solution.CoinChange(coins, amount);
        result.ShouldBe(4);
    }
    
    [Fact]
    public void CoinChange_1()
    {
        int[] coins = [186,419,83,408];
        int amount = 6249;
        var solution = new KnapsackProblem();
        var result = solution.CoinChange(coins, amount);
        result.ShouldBe(4);
    }
}