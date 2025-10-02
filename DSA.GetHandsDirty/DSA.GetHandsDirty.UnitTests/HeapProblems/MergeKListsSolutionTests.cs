using DSA.GetHandsDirty.HeapProblems;
using DSA.MyDataStructures.LeetCodeStructures;

namespace DSA.GetHandsDirty.UnitTests.HeapProblems;

public class MergeKListsSolutionTests
{
    [Fact]
    public void MergeKLists_GivenThreeListsOfIntegers_ShouldMergeAllIntoOneSortedLinkedList()
    {
        var list1 = new ListNode(1, new ListNode(4, new ListNode(5)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var list3 = new ListNode(2, new ListNode(6));

        ListNode[] arrayOfLists = [list1, list2, list3];
        
        var solution = new MergeKListsSolution();
        var mergedFirstNode = solution.MergeKLists(arrayOfLists); 
        
        int[] expected = [1, 1, 2, 3, 4, 4, 5, 6];
        foreach (var t in expected)
        {
            if (mergedFirstNode is null)
                continue;
            
            mergedFirstNode.val.ShouldBe(t);
            mergedFirstNode = mergedFirstNode.next;
        }
    }
    
    [Fact]
    public void MergeKLists_GivenAnEmptyList_ShouldReturnEmptyNode()
    {
        ListNode[] arrayOfLists = [];
        
        var solution = new MergeKListsSolution();
        var emptyNode = solution.MergeKLists(arrayOfLists); 
        emptyNode.ShouldBeNull();
    }
    
    [Fact]
    public void MergeKLists_GivenAListWithOneEmptyList_ShouldReturnEmptyNode()
    {
        var emptyList = default(ListNode);
        ListNode[] arrayOfLists = [emptyList];
        
        var solution = new MergeKListsSolution();
        var emptyNode = solution.MergeKLists(arrayOfLists); 
        emptyNode.ShouldBeNull();
    }
}