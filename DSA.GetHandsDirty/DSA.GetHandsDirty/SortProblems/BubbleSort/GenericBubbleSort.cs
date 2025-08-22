namespace DSA.GetHandsDirty.SortProblems.BubbleSort;

public static class GenericBubbleSort
{
    // O(n²) tempo quadratico
    public static void Sort(int[] nums)
    {
        foreach (var _ in nums)
        {
            var isOrdered = true;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    isOrdered = false;
                    (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
                }
            }
            if (isOrdered)
                return;
        }
    }
}