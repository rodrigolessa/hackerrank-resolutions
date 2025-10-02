namespace DSA.GetHandsDirty.DynamicProgrammingTechnique;

/// <summary>
/// LeetCode 91 - https://leetcode.com/problems/decode-ways/description/
/// </summary>
public class DecoyWaysProblem
{
    public int NumDecodings(string s)
    {
        if (string.IsNullOrWhiteSpace(s) || s[0] == '0')
            return 0;
        
        // Representam a quantidade de combinações/possibilidades de strings diferentes
        int previous = 1;
        int current = 1;

        for (int i = 1; i <= s.Length; i++)
        {
            int t = 0;
            if (s[i] != '0')
            {
                t += current;
            }

            //int twoDigits = s.Substring(i - 1, 2); // twod = int(s[i-1:i+1])
            // if 10 <= twod <= 26
                // temp += previous;
                
            (previous, current) = (current, t);

            if (current == 0)
                return 0;
        }

        return current;
    }
}