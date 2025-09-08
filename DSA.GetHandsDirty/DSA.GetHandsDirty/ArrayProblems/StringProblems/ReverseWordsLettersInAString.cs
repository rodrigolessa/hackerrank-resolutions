using DSA.GetHandsDirty.StringProblems;

namespace DSA.GetHandsDirty.ArrayProblems.StringProblems;

public static class ReverseWordsLettersInAString
{
    public static string Reverse(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return string.Empty;

        var array = s.ToCharArray();
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
    
    public static string AlternativeReverseWords(string s) {
        char[] chars = s.ToCharArray();
        int start = 0;
        int count = 0;
        int length = chars.Length;
        for(int i=0; i<length; i++){
            if(chars[i] == ' '){
                Array.Reverse(chars,start, count);
                start = i+1;
                count =0;
            }
            else{
                count++;
            }
        }
        Array.Reverse(chars,start,count);
        return new string(chars);
    }
}