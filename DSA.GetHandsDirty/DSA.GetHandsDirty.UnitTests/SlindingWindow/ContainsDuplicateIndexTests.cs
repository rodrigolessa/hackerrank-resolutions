using DSA.GetHandsDirty.SlidingWindow;

namespace DSA.GetHandsDirty.UnitTests.SlindingWindow;

public class ContainsDuplicateIndexTests
{
    [Fact]
    public void ContainsNearbyDuplicate_GivenAIntegerArrayWithOneRepetitionInsideTheWindow_ShouldReturnFalse()
    {
        int[] nums = [1,2,3,1];
        int k = 3;
        bool result = ContainsNearbyDuplicate.ContainsDuplicateIndex(nums, k);
        result.ShouldBeTrue();
    }
    
    [Fact]
    public void ContainsNearbyDuplicate_WhenTheArrayHasMoreThanOneDuplicateIndex_ShouldReturnTrue()
    {
        int[] nums = [1,0,1,1];
        int k = 1;
        bool result = ContainsNearbyDuplicate.ContainsDuplicateIndex(nums, k);
        result.ShouldBeTrue();
    }
    
    [Fact]
    public void ContainsNearbyDuplicate_WhenTheDuplicateIndexIsDistant_ShouldReturnFalse()
    {
        int[] nums = [1,2,3,1,2,3];
        int k = 2;
        bool result = ContainsNearbyDuplicate.ContainsDuplicateIndex(nums, k);
        result.ShouldBeFalse();
    }
    
    [Fact]
    public void ContainsNearbyDuplicate_WhenTheDuplicateIsTooNear_ShouldReturnTrue()
    {
        int[] nums = [0,1,2,3,2,5];
        int k = 2;
        bool result = ContainsNearbyDuplicate.ContainsDuplicateIndex(nums, k);
        result.ShouldBeTrue();
    }
}