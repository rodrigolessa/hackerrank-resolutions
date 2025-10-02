using System.Runtime.InteropServices.Marshalling;
using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.LinkedListProblems;

public static class MergeTwoLists
{
    public static MyNode<int> MergeAndSort(MyNode<int>? list1, MyNode<int>? list2)
    {
        if (list1 is null)
            return list2;
        
        if (list2 is null)
            return list1;
        
        return Merge(list1, list2);
    }

    private static MyNode<int> Merge(MyNode<int> list1, MyNode<int> list2)
    {
        // Initialize a new list with empty node
        var head = new MyNode<int>(0);
        var tail = head;

        while (list1 is not null && list2 is not null)
        {
            if (list1.Value > list2.Value)
            {
                // Sempre adiciona o valor maior como última posição da nova lista 
                tail.Next = list2;
                list2 = list2.Next; // Move o cursor da lista
            }
            else
            {
                tail.Next = list1;
                list1 = list1.Next;
            }
            tail = tail.Next;
        }
        
        // Adiciona o node que sobrou
        tail.Next = list1 ?? list2;
        
        // Discard the empty node
        return head.Next;
    }
}