using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.HeapProblems;

public class TopKFrequentElements
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        if (nums.Length == 0 || k <= 0)
            return [];
        
        if (nums.Length == k)
            return nums;
        
        Dictionary<int, int> counter = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (!counter.TryAdd(num, 0))
                counter[num]++;
        }

        PriorityQueue<int, int> leastFrequencyOrder = new PriorityQueue<int, int>();
        foreach (var e in counter)
        {
            leastFrequencyOrder.Enqueue(e.Key, e.Value);
            if (leastFrequencyOrder.Count > k)
                leastFrequencyOrder.Dequeue();
        }

        int[] topK = new int[k];
        for (int i = k - 1; i >= 0; i--)
            topK[i] = leastFrequencyOrder.Dequeue();

        return topK;
    }
}