namespace DSA.GetHandsDirty.StringProblems;

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
        var writeIndex = 0;
        var previousSpace = false; // tracks whether the previous character was a space.

        ReverseAnEntireString.ReverseSubset(left, right, chars);

        right = 0;
        while (right < chars.Length)
        {
            if (chars[right] == ' ')
            {
                if (!previousSpace)
                {
                    chars[writeIndex++] = ' ';
                    previousSpace = true;
                }
                
                ReverseAnEntireString.ReverseSubset(left, right - 1, chars);
                right++;
                left = right;
                continue;
            }

            chars[writeIndex++] = chars[right];
            previousSpace = false;

            right++;
        }

        ReverseAnEntireString.ReverseSubset(left, right - 1, chars);

        if (writeIndex > 0 && chars[writeIndex - 1] == ' ')
            writeIndex--;

        return new string(chars, 0, writeIndex);
    }
}