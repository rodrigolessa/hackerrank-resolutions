namespace DSA.GetHandsDirty.LinkedListProblems;

public class ReverseSubsection
{
    public class ListNode
    {
        public int Value;
        public ListNode? Next;

        public ListNode(int value = 0, ListNode? next = null)
        {
            this.Value = value;
            this.Next = next;
        }
    }

    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        if (head.Next == null || left == right || left > right)
            return head;

        // Dummy node to simplify edge case when reversing from head
        var newFirstNode = new ListNode(0, head);
        var nodeBeforeReversed = newFirstNode;

        // Step 1: Move `previous` to node before the reversal starts
        for (var i = 1; i < left; i++)
            nodeBeforeReversed = nodeBeforeReversed.Next!;

        var current = nodeBeforeReversed.Next;
        ListNode? prevReversed = null;

        // Step 2: Reverse the sublist from left to right
        for (var i = 0; i <= right - left; i++)
        {
            var nextNode = current!.Next;
            current.Next = prevReversed;
            prevReversed = current;
            current = nextNode;
        }

        // Step 3: Reconnect
        var nodeAfterReversed = current;

        nodeBeforeReversed.Next!.Next = nodeAfterReversed;
        nodeBeforeReversed.Next = prevReversed;

        return newFirstNode.Next!;
    }
}