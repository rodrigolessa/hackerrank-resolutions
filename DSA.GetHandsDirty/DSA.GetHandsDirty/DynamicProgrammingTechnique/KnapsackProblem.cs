namespace DSA.GetHandsDirty.DynamicProgrammingTechnique;

/// <summary>
/// LeetCode 322
/// Uma matriz para encontrar a melhor combinação até uma próxima verificação
/// para um amount de 10 com coins [1, 2, 5]
///     | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 - ammount columns
/// ------------------------------------------
/// 1 - | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 - combinações necessárias 
/// 2 - | 0 | 1 | 1 | 2 | 2 | 3 | 3 | 4 |  |  | 
/// 5 - | 0 | 1 | 1 | 2 | 2 | 1 | 2 |  |  |  | 
/// </summary>
public class KnapsackProblem
{
    public int CoinChange(int[] coins, int amount)
    {
        if (amount <= 0)
            return 0;

        foreach (var _ in coins)
        {
            for (int i = 0; i < coins.Length - 1; i++)
            {
                if (coins[i] > coins[i + 1])
                {
                    (coins[i], coins[i + 1]) = (coins[i + 1], coins[i]);
                }
            }
        }

        int[] mc = Enumerable.Repeat(int.MaxValue, amount + 1).ToArray(); // best minimum combination array
        mc[0] = 0;
        foreach (int coin in coins)
        {
            for (int i = coin; i <= amount; i++)
            {
                mc[i] = Math.Min(mc[i], mc[i - coin] + 1);
            }
        }

        return mc[amount] == int.MaxValue || mc[amount] < 0 ? -1 : mc[amount];
    }
}