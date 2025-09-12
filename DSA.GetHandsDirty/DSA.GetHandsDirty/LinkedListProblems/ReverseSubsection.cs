using DSA.MyDataStructures.LeetCodeStructures;

namespace DSA.GetHandsDirty.LinkedListProblems;

public class ReverseSubsection
{
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        if (head.next == null || left == right || left > right)
            return head;

        // Dummy node to simplify edge case when reversing from head
        var newFirstNode = new ListNode(0, head);
        var nodeBeforeReversed = newFirstNode;

        // Step 1: Move `previous` to node before the reversal starts
        for (var i = 1; i < left; i++)
            nodeBeforeReversed = nodeBeforeReversed.next!;

        var current = nodeBeforeReversed.next;
        ListNode? prevReversed = null;

        // Step 2: Reverse the sublist from left to right
        for (var i = 0; i <= right - left; i++)
        {
            var nextNode = current!.next;
            current.next = prevReversed;
            prevReversed = current;
            current = nextNode;
        }

        // Step 3: Reconnect
        var nodeAfterReversed = current;

        nodeBeforeReversed.next!.next = nodeAfterReversed;
        nodeBeforeReversed.next = prevReversed;

        return newFirstNode.next!;
    }
}