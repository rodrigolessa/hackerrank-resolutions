namespace DSA.GetHandsDirty.DynamicProgrammingTechnique;

/// <summary>
/// LeetCode 70 - Semelhante a Fibonacci.
/// Para entender quantas formas eu posso usar para chegar em um degrau basta somar as duas formas anteriores
/// </summary>
public class ClimbingStairsProblem
{
    public int ClimbStairs(int n)
    {
        int[] steps = new int[n+1];
        steps[0] = 1;
        steps[1] = 1;
        for (int i = 2; i <= n; i++)
            steps[i] = steps[i - 1] + steps[i - 2];
        return steps[n];
    }
}