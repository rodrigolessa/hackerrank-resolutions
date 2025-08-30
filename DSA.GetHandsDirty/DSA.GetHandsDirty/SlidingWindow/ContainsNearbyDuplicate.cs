namespace DSA.GetHandsDirty.SlidingWindow;

public static class ContainsNearbyDuplicate
{
    public static bool ContainsDuplicateIndex(int[] nums, int distance)
    {
        if (distance == 0)
            return false;

        int left = 0;
        int right = 1;
        HashSet<int> counter = [];
        counter.Add(nums[0]);
        while (right < nums.Length)
        {
            if (!counter.Add(nums[right]))
                return true;

            right++;
            if ((right - left) > distance)
            {
                counter.Remove(nums[left]);
                left++;
            }
        }

        return false;
    }
    
    public static bool FasterContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> seen = new(nums.Length);

        for (int i = 0; i < nums.Length; i++)
        {
            // Ainda não foi visto
            // Associa o valor com a posição dele na sequencia da lista
            if (seen.TryAdd(nums[i], i))
                continue;

            // Verifica a distância da posição que já existe até a última vez que foi visto
            if (seen.ContainsKey(nums[i]) && i - seen[nums[i]] <= k)
            {
                return true;
            }

            // Se possuir valor duplicado sobrescreve com a última posição
            seen[nums[i]] = i;
        }

        return false;
    }
}