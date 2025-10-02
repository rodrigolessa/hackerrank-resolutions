namespace DSA.GetHandsDirty.BinaryOperationProblems;

/// <summary>
/// Given an integer num, return the number of steps to reduce it to zero.
/// In one step, if the current number is even, you have to divide it by 2,
/// otherwise, you have to subtract 1 from it.
/// </summary>
public static class NumberOfStepsToReduceToZero
{
    public static int Reduce(int num)
    {
        int steps = 0;
        while (num > 0)
        {
            if ((num & 1) != 0)
                num -= 1;
            else
                num >>= 1;
            steps++;
        }
        return steps;
    }
}