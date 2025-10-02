namespace DSA.GetHandsDirty.ArrayProblems.StringProblems;

public static class LengthOfLongestSubstring
{
    /// <summary>
    /// Encontrar a maior sequencia de caracteres onde nenhum deles se repete.
    /// Normalmente é um problema de sliding window mas para esse cenário essa solução com um loop é mais eficiente.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static int FindInOneIteration(string s) {
        Dictionary<char,int> map = new Dictionary<char,int>();
        int maxLength = 0;
        int left = 0;
        
        for(int right = 0;right<s.Length;right++){
            if(map.ContainsKey(s[right])){
                left = Math.Max(left,map[s[right]]+1);
            }
            map[s[right]] = right;
            maxLength = Math.Max(maxLength, right-left+1);
        }
        return maxLength;
    }
    
    public static int FindWithMinimalOverhead(string s) {
        if (string.IsNullOrEmpty(s)) return 0;

        return LengthAscii(s);
    }

    // O(n), minimal overhead (no hashing)
    private static int LengthAscii(string s) {
        Span<int> last = stackalloc int[128];
        for (int i = 0; i < last.Length; i++) last[i] = -1;

        int best = 0, left = 0;
        for (int right = 0; right < s.Length; right++) {
            int c = s[right];
            int prev = last[c];
            if (prev >= left) left = prev + 1;
            last[c] = right;
            int len = right - left + 1;
            if (len > best) best = len;
        }
        return best;
    }
}