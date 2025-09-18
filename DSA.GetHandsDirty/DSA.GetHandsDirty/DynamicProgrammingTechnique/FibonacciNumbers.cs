namespace DSA.GetHandsDirty.DynamicProgrammingTecnique;

/// <summary>
/// Reference:
/// https://www.geeksforgeeks.org/competitive-programming/dynamic-programming/
/// 1 - Given a positive integer n, calculate the n-th number in the sequence.
/// 2 - Display a certain number of terms in the sequence, for example, the first 10 or 20 numbers.  
/// </summary>
public class FibonacciNumbers
{
    public int FindingNthFibonacciNumber(int n)
    {
        int[] sequence = new int[n + 1];
        sequence[0] = 1;
        sequence[1] = 1;
        for (int i = 2; i <= n; i++)
        {
            sequence[i] = sequence[i - 1] + sequence[i - 2];
        }
        return sequence[n];
    }
}