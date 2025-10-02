namespace DSA.GetHandsDirty.DynamicProgrammingTechnique;

/// <summary>
/// LeetCode 1049 - https://leetcode.com/problems/last-stone-weight-ii/
/// </summary>
public class LastStoneWeight2Problem
{
    public int LastStoneWeight(int[] stones)
    {
        // total = sum(stones)
        // Max_weight = total // 2
        // current = [0] * (Max_weight + 1)
        //
        // for stone in stones:
        // for wgt in range(Max_weight, stone - 1, -1):
        // current[wgt] = max(current[wgt], stone + current[wgt - stone])
        //
        // return total - 2 * current[Max_weight]
        return 0;
    }
}