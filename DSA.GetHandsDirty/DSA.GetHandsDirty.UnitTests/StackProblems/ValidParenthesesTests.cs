using DSA.GetHandsDirty.StackProblems;

namespace DSA.GetHandsDirty.UnitTests.StackProblems;

public class ValidParenthesesTests
{
    [Theory]
    [InlineData("}", false)]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("{[()]}", true)]
    [InlineData("(]", false)]
    [InlineData("([])", true)]
    [InlineData("([)]", false)]
    [InlineData("{[(]}", false)]
    public void IsValid_(string input, bool expected)
    {
        var solution = new ValidParenthesesProblem();
        solution.IsValid(input).ShouldBe(expected);
    }
}