namespace DSA.GetHandsDirty.StringProblems;

/// <summary>
/// LeetCode 151 - Medium
/// </summary>
public static class ReverseWordsPositionsInAString
{
    /// <summary>
    /// The best algorithm I know it one use a Two Pointer technique
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static object Reverse(string input)
    {
        var chars = input.ToArray();
        var left = 0;
        var right = chars.Length - 1;

        // First - reverse the entire string
        ReverseAnEntireString.ReverseSubset(left, right, chars);

        right = 0;
        while (right < chars.Length)
        {
            // Then - find where words are in the string looking for blank space
            if (chars[right] == ' ')
            {
                // And - reverse this substring
                ReverseAnEntireString.ReverseSubset(left, right - 1, chars);
                right++;
                left = right;
                continue;
            }

            right++;
        }

        // And - Reverse the last word that was left behind
        ReverseAnEntireString.ReverseSubset(left, right - 1, chars);

        return new string(chars);
    }

    public static object ReverseRemovingSpace(string input)
    {
        char[] chars = input.ToArray();
        int startIndex = 0;
        // Check there are blank spaces at the beginning
        while (startIndex < chars.Length && chars[startIndex] == ' ')
            startIndex++;

        int left = startIndex;
        int right = chars.Length - 1;
        // First - reverse the entire string
        ReverseAnEntireString.ReverseSubset(left, right, chars);
        
        while (startIndex < chars.Length && chars[startIndex] == ' ')
            startIndex++;

        //bool previousSpace = false; // tracks whether the previous character was a space.
        
        left = startIndex;
        right = startIndex;
        while (right < chars.Length)
        {
            // Then - find where words are in the string looking for blank space
            if (chars[right] == ' ')
            {
                // if (!previousSpace)
                // {
                //     chars[writeIndex++] = ' ';
                //     previousSpace = true;
                // }

                // And - reverse this substring
                ReverseAnEntireString.ReverseSubset(left, right - 1, chars);
                right++;
                left = right;
                continue;
            }

            //chars[writeIndex++] = chars[right];
            //previousSpace = false;

            right++;
        }

        // And - Reverse the last word that was left behind
        ReverseAnEntireString.ReverseSubset(left, right - 1, chars);

        return new string(chars, startIndex, chars.Length - startIndex);
    }
}