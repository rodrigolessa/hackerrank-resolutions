namespace DSA.GetHandsDirty.SlidingWindow;

public static class FindSequenceThatDoesNotRepeat
{
    public static int Find(string input, int maxAllowed)
    {
        if (string.IsNullOrWhiteSpace(input))
            return 0;

        var left = 0;
        var right = 0;

        var counter = new Dictionary<char, int> { { input[right], 1 } };
        var longestSequence = 1;

        while (right < input.Length - 1)
        {
            right++;
            if (!counter.TryAdd(input[right], 1))
            {
                counter[input[right]] += 1;
            }

            while (counter[input[right]] > maxAllowed)
            {
                counter[input[left]] -= 1;
                left++;
            }

            longestSequence = Math.Max(longestSequence, right - left + 1);
        }

        return longestSequence;
    }
}