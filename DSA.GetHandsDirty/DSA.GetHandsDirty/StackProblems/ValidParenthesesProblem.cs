namespace DSA.GetHandsDirty.StackProblems;

/// <summary>
/// LeetCode 20 - https://leetcode.com/problems/valid-parentheses/
/// </summary>
public class ValidParenthesesProblem
{
    private readonly Dictionary<char, char> map = new Dictionary<char, char>()
    {
        { '}', '{' },
        { ']', '[' },
        { ')', '(' }
    };

    public bool IsValid(string s)
    {
        int length = s.Length;
        if ((length & 1) == 1) return false; // Nunca pode ser impar
        
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            if (map.ContainsKey(c)) // Encontrou um fechamento ") ] }"
            {
                if (stack.Count > 0 && stack.Peek() == map[c])
                    stack.Pop();
                else
                    return false;
            }
            else // Encontrou uma abertura "( [ {"
                stack.Push(c);
        }

        return stack.Count == 0;
    }
}