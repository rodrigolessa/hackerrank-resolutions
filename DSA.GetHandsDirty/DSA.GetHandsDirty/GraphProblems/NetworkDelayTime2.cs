namespace DSA.GetHandsDirty.GraphProblems;

public class NetworkDelayTime2
{
    public int FindTheMinimumTime(int[][] times, int n, int k)
    {
        int max = -1;
        Dictionary<int, List<(int, int)>> networkMap = new Dictionary<int, List<(int, int)>>();
        foreach (int[] t in times)
        {
            if (!networkMap.ContainsKey(t[0]))
            {
                networkMap[t[0]].Add((t[1], t[2]));
            }
            else
            {
                networkMap.Add(t[0], new List<(int, int)> { (t[1], t[2]) });
            }
        }

        Dictionary<int, int> distances = new Dictionary<int, int> { { k, 0 } };

        PriorityQueue<(int, int), int> minheap = new PriorityQueue<(int, int), int>();
        minheap.Enqueue((k, 0), 0);

        while (minheap.Count > 0)
        {
            var node = minheap.Dequeue();
            var neighbors = networkMap[node.Item1];
            if (neighbors?.Count > 0)
            {
                foreach ((int neighbor, int distance) in neighbors)
                {
                    var table_dist = int.MaxValue;
                    if (distances.ContainsKey(neighbor))
                    {
                        table_dist = distances[neighbor];
                        if (node.Item2 + distance < table_dist)
                        {
                            distances[neighbor] = node.Item2 + distance;
                            minheap.Enqueue((neighbor, node.Item2 + distance), node.Item2 + distance);
                        }
                    }
                    else
                    {
                        distances.Add(neighbor, node.Item2 + distance);
                        minheap.Enqueue((neighbor, node.Item2 + distance), node.Item2 + distance);
                    }
                }
            }
        }

        if (distances.Count < n)
            return max;

        foreach (int v in distances.Values)
            max = Math.Max(max, v);

        if (max == 0)
            return -1;

        return max;
    }
}