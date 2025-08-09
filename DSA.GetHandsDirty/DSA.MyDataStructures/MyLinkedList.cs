using System.Diagnostics;
using System.Runtime;
using DSA.MyDataStructures.Abstractions;

namespace DSA.MyDataStructures;

public class MyLinkedNode<T>(T value)
{
    public T Value { get; set; } = value;
    public MyLinkedNode<T>? Previous { get; set; }
    public MyLinkedNode<T>? Next { get; set; }
}

public class MyLinkedList<T> : IMyLinkedList<T>
{
    public MyLinkedNode<T>? Head { get; set; }
    public MyLinkedNode<T>? Tail { get; set; }

    public IMyLinkedList<T> AddInFirstPosition(T value)
    {
        var node = new MyLinkedNode<T>(value);
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
        var node = new MyLinkedNode<T>(value);
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

        MyLinkedNode<T> currentNode = default;
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
}