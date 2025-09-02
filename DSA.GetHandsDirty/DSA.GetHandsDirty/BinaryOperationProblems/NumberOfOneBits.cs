namespace DSA.GetHandsDirty.BinaryOperationProblems;

/// <summary>
/// Given a positive integer n, write a function that returns the number of set bits in its binary representation
/// (also known as the Hamming weight)
/// </summary>
public static class NumberOfOneBits
{
    public static int HammingWeight(int n)
    {
        int oneBits = 0;
        while (n > 0)
        {
            if ((n & 1) != 0)
            {
                oneBits++;
            }

            n >>= 1;
        }
        return oneBits;
    }

    public static int[] CountingOneBits(int n)
    {
        int[] arr = new int[n + 1];
        for (int i = 0; i <= n; i++)
        {
            arr[i] = HammingWeight(i);
        }

        return arr;
    }
    
    public static int[] CountBitsBestPerformance(int n) {
        int[] dp = new int[n+1];
        dp[0] = 0;

        for(int i = 1; i < n+1; i++)
        {
            dp[i] = dp[i >> 1] + (1 & i);
        }


        return dp;
    }
}