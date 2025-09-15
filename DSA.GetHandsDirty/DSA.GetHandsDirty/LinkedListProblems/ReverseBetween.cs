using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.LinkedListProblems;

public static class ReverseBetween<T>
{
    public static MyNode<T> Execute(MyNode<T> head, int left, int right)
    {
        if (head.Next is null || left == 0)
            return head;

        while (left < right)
        {
            var leftNode = FindNodeByPosition(head, left);
            var rightNode = FindNodeByPosition(head, right);

            (leftNode.Value, rightNode.Value) = (rightNode.Value, leftNode.Value);

            left++;
            right--;
        }

        return head;
    }

    private static MyNode<T> FindNodeByPosition(MyNode<T> head, int position)
    {
        if (position == 1)
        {
            return head;
        }

        var currentNode = head;

        for (int i = 1; i < position; i++)
        {
            currentNode = currentNode.Next;
        }
        
        return currentNode;
    }
}