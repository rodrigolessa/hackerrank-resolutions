using System.Runtime.CompilerServices;
using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.LinkedListProblems;

public static class FindTheMiddle<T>
{
    public static MyLinkedNode<T> Find(MyLinkedNode<T> head)
    {
        var slow = head;
        var fast = head;
        while (fast?.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
        }

        return slow;
    }
}