namespace DSA.GetHandsDirty.HeapProblems;

/// <summary>
/// Using PriorityQueue built-in data structure
/// </summary>
public class KthLargest
{
    private PriorityQueue<int, int> _scores = new PriorityQueue<int, int>();
    private readonly int _cutOffMark;

    public KthLargest(int k, int[] nums)
    {
        _cutOffMark = k;

        foreach (var score in nums)
        {
            _scores.Enqueue(score, score);
        }

        while (_scores.Count > _cutOffMark)
        {
            _scores.Dequeue();
        }
    }

    public int Add(int val)
    {
        _scores.Enqueue(val, val);
        if (_scores.Count > _cutOffMark)
            _scores.Dequeue();

        return _scores.Peek();
    }
}