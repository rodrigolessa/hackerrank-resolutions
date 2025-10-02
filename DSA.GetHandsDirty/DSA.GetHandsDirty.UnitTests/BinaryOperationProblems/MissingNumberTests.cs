using DSA.GetHandsDirty.BinaryOperationProblems;

namespace DSA.GetHandsDirty.UnitTests.BinaryOperationProblems;

public class MissingNumberTests
{
    [Fact]
    public void FindMissingNumber_GivenThreeDistinctNumbersInTheRange_ShouldReturnTheMissingOne()
    {
        int[] nums = [3, 0, 1];
        int output = 2;
        var result = MissingNumber.Find(nums);
        result.ShouldBe(output);
    }
    
    [Fact]
    public void FindMissingNumber_GivenTwoNumbers_ShouldReturnTheMissingOne()
    {
        int[] nums = [0, 1];
        int output = 2;
        var result = MissingNumber.Find(nums);
        result.ShouldBe(output);
    }
    
    [Fact]
    public void FindMissingNumber_GivenEightNumbers_ShouldReturnTheMissingOne()
    {
        int[] nums = [9, 6, 4, 2, 3, 5, 7, 0, 1];
        int output = 8;
        var result = MissingNumber.Find(nums);
        result.ShouldBe(output);
    }
}