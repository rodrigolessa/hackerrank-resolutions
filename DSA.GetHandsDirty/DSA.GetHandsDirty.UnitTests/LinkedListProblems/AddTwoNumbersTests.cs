using DSA.GetHandsDirty.LinkedListProblems;
using DSA.MyDataStructures.LeetCodeStructures;

namespace DSA.GetHandsDirty.UnitTests.LinkedListProblems;

public class AddTwoNumbersTests
{
    [Fact]
    public void AddTwoNumbers_GivenOneArrayBigger_ShouldReturnTheOfTheBiggerOne()
    {
        ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode( 9)))))));
        ListNode l2 =  new ListNode(9,  new ListNode(9,  new ListNode(9,  new ListNode(9))));
        var solution = new AddTwoNumbersProblem();
        var sum = solution.AddTwoNumbers(l1, l2);
        sum.val.ShouldBe(8);
        sum.next.val.ShouldBe(9);
        sum.next.next.val.ShouldBe(9);
        sum.next.next.next.val.ShouldBe(9);
        sum.next.next.next.next.val.ShouldBe(0);
        sum.next.next.next.next.next.val.ShouldBe(0);
        sum.next.next.next.next.next.next.val.ShouldBe(0);
        sum.next.next.next.next.next.next.next.val.ShouldBe(1);
    }
}