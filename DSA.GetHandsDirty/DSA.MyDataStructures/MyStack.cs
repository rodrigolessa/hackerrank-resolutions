namespace DSA.MyDataStructures;

/// <summary>
/// LIFO behavior (Last-In-First-Out):
/// - Push(int data)
/// - int Pop()
/// </summary>
public class MyStack
{
    private int _size = 0;
    private MyNode<int>? _top; // Head like in a queue
    
    public void Push(int data)
    {
        var newNode = new MyNode<int>(data)
        {
            Next = _top
        };
        _top = newNode;
        _size++;
    }

    public int? Pop()
    {
        if (_size == 0)
            return null;

        if (_top is null)
            return null;
        
        var removed = _top;
        
        _top = _top?.Next;
        _size--;
        
        return removed.Value;
    }

    public int? Peek()
    {
        if (_size == 0)
            return null;

        return _top?.Value;
    }

    public int Size()
    {
        return _size;
    }
}