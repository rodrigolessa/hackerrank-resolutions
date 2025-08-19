using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.LinkedListProblems;

public static class FindCircularReference<T>
{
    public static bool HasCycle(MyLinkedNode<T> head, out int steps)
    {
        steps = 0;
        var slow = head;
        var fast = head;
        while (fast?.Next != null)
        {
            steps++;
            slow = slow.Next;
            fast = fast.Next.Next;
            if (slow == fast)
            {
                return true;
            }
        }
        
        return false;
    }
}