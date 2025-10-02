namespace DSA.GetHandsDirty.BinaryOperationProblems;

public static class MissingNumber
{
    public static int Find(int[] nums)
    {
        var x = 0;
        foreach (var num in nums)
        {
            x ^= num;
        }

        for (int i = 0; i <= nums.Length; i++)
        {
            x ^= i;
        }
        
        return x;
    }
}