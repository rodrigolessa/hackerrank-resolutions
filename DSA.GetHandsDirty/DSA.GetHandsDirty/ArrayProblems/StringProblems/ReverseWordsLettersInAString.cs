using DSA.GetHandsDirty.StringProblems;

namespace DSA.GetHandsDirty.ArrayProblems.StringProblems;

public static class ReverseWordsLettersInAString
{
    public static string Reverse(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        var array = input.ToCharArray();
        var left = 0;
        var right = 0;
        while (right < array.Length)
        {
            if (array[right] == ' ' || right + 1 == array.Length)
            {
                ReverseAnEntireString.ReverseSubset(left, array[right] == ' ' ? right - 1 : right, array);
                left = right + 1;
            }

            right++;
        }

        return new string(array);
    }
}