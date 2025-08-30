namespace DSA.GetHandsDirty.HashMapProblems;

public static class TwoSum
{
    public static int[] Sum(int[] nums, int target) {
        var d = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];
            if (d.TryGetValue(diff, out var position))
            {
                return [position, i];
            }
            d.TryAdd(nums[i], i);
        }
        
        return null;
    }
}