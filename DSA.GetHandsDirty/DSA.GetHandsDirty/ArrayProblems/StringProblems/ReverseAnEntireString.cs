namespace DSA.GetHandsDirty.StringProblems;

public static class ReverseAnEntireString
{
    /// <summary>
    /// Uses a two-pointer technique
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string Reverse(string input)
    {
        var chars = input.ToCharArray();
        var left = 0;
        var right = chars.Length - 1;
        ReverseSubset(left, right, chars);

        return new string(chars);
    }

    /// <summary>
    /// Existe uma solução em .Net que faz isso
    /// - Array.Reverse(chars, start, count);
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <param name="chars"></param>
    public static void ReverseSubset(int left, int right, char[] chars)
    {
        while (left < right)
        {
            (chars[left], chars[right]) = (chars[right], chars[left]);
            left++; 
            right--;
        }
    }

    // Considerations:
    // Do not use a script like that one:
    // string reversed = "";
    // foreach (char c in input);
    //      reversed = c + reversed; // O(n²) due to string concatenation
    // This creates a new string on every iteration
    // Terrible for performance
}