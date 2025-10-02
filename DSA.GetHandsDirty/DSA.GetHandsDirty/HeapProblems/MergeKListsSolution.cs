using DSA.MyDataStructures.LeetCodeStructures;

namespace DSA.GetHandsDirty.HeapProblems;

/// <summary>
/// LeetCode Hard Problem - 23 - https://leetcode.com/problems/merge-k-sorted-lists/description/
/// </summary>
public class MergeKListsSolution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists is null || lists.Length == 0)
            return default;

        PriorityQueue<ListNode, int> queue = new PriorityQueue<ListNode, int>();
        foreach (var node in lists)
        {
            if (node is null)
                continue;
            queue.Enqueue(node, node.val);
        }
        
        if (queue.Count == 0)
            return default;

        ListNode emptyHead = new ListNode();
        ListNode mergedTail = emptyHead;
        
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            mergedTail.next = node;
            mergedTail = mergedTail.next;
            if (node.next is not null)
                queue.Enqueue(node.next, node.next.val);
        }
        
        return emptyHead.next;
    }
}