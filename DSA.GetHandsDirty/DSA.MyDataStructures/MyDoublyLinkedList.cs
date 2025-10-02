namespace DSA.MyDataStructures;

public class MyDoublyLinkedList<T>
{
    public MyNode<T>? Head { get; set; }
    public MyNode<T>? Tail { get; set; }

    public void InsertAtTheBeginning(T value)
    {
        var node = new MyNode<T>(value);
        if (Head is not null)
        {
            node.Next = Head;
            Head.Previous = node;
        }

        Head = node;
        Tail ??= node;
    }

    public void InsertAtTheEnd(T value)
    {
        var node = new MyNode<T>(value);
        if (Tail is not null)
        {
            Tail.Next = node;
            node.Previous = Tail;
        }
        
        Tail = node;
        Head ??= node;
    }

    public T? TakeFromTheBeginning()
    {
        if (Head is null)
            return default;
        
        var removedValue = Head.Value;

        if (Head.Next is null)
        {
            Head = null;
            Tail = null;
        }
        else
        {
            Head = Head.Next;
            Head.Previous = null;
        }

        return removedValue;
    }

    public T? TakeFromTheEnd()
    {
        if (Tail is null)
            return default;

        var removedValue = Tail.Value;

        if (Tail.Previous is null)
        {
            Head = null;
            Tail = null;
        }
        else
        {
            Tail = Tail.Previous;
            Tail.Next = null;
        }
        
        return removedValue;
    }
}