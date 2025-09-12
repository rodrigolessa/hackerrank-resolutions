using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.HeapProblems;

/// <summary>
/// LeetCode 703 - https://leetcode.com/problems/kth-largest-element-in-a-stream/description/
/// </summary>
public class KthLargestElementInStream
{
    private MyMinHeap<int> scores = new MyMinHeap<int>();
    private readonly int cutOffMark;
    
    public KthLargestElementInStream(int k, int[] nums)
    {
        cutOffMark = k;
        
        foreach (var score in nums)
        {
            scores.Insert(score);
        }
        
        while (scores.Count > k)
        {
            scores.Pop();
        }
    }

    public int Add(int val)
    {
        scores.Insert(val);

        if (scores.Count > cutOffMark)
            scores.Pop();
        
        return scores.Peek();
    }
}