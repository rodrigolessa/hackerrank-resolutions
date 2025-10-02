using System.Diagnostics;
using System.Runtime;
using DSA.MyDataStructures.Abstractions;

namespace DSA.MyDataStructures;

public class MyLinkedList<T> : IMyLinkedList<T>
{
    public MyNode<T>? Head { get; set; }
    public MyNode<T>? Tail { get; set; }

    public IMyLinkedList<T> AddInFirstPosition(T value)
    {
        var node = new MyNode<T>(value);
        if (Head is not null)
        {
            node.Next = Head;
        }

        Head = node;
        Tail ??= node;

        return this;
    }

    public IMyLinkedList<T> AddInLastPosition(T value)
    {
        var node = new MyNode<T>(value);
        if (Tail is not null)
        {
            Tail.Next = node;
        }

        Tail = node;
        Head ??= node;

        return this;
    }

    public T? RemoveFirstPosition()
    {
        if (Head is null)
            return default;

        var headValue = Head.Value;

        if (Head.Next is not null)
        {
            Head = Head.Next;
        }

        return headValue;
    }

    public T? RemoveLastPosition()
    {
        if (Tail is null)
            return default;

        var tailValue = Tail.Value;
        var currentPosition = Head;

        while (currentPosition?.Next is not null)
        {
            if (currentPosition.Next == Tail)
            {
                currentPosition.Next = null;
                Tail = currentPosition;
                break;
            }

            currentPosition = currentPosition?.Next;
        }

        return tailValue;
    }

    public int HowMany()
    {
        if (Head is null)
            return 0;

        // TODO: Check if has a circular reference

        var counter = 1;
        var currentPosition = Head;
        while (currentPosition?.Next is not null)
        {
            counter++;
            currentPosition = currentPosition.Next;
        }

        return counter;
    }

    public void Reverse()
    {
        if (Head is null)
            return;

        MyNode<T> currentNode = default;
        var nextNode = Head;
        while (nextNode is not null)
        {
            nextNode = Head.Next;
            Head.Next = currentNode;
            currentNode = Head;
            if (nextNode is not null)
                Head = nextNode;
        }
    }

    public T[] ToArray()
    {
        if (Head is null)
            return [];
        
        var len = HowMany();
        var arr = new T[len];
        var currentNode = Head;

        for (var i = 0; i < len; i++)
        {
            arr[i] = currentNode.Value;
            if (currentNode.Next is not null)
            {
                currentNode = currentNode.Next;
            }
        }

        return arr;
    }
}