namespace DSA.MyDataStructures;

/// <summary>
/// FIFO behavior (First-In-First-Out)
/// O padrão é implementado com uma linkedList
/// </summary>
public class MyQueue<T>
{
    public MyNode<T>? Head { get; set; }
    public MyNode<T>? Tail { get; set; }

    public void Enqueue(T item) // PUT - Insert at last position
    {
        if (Head is null)
            Head = new MyNode<T>(item);
        
        if (Tail is null)
            Tail = new MyNode<T>(item);
        else
        {
            Tail.Next = new MyNode<T>(item);
            Tail = Tail.Next;
        }
    }

    public MyNode<T>? Dequeue() // POP OR GET - Return first element and remove it;
    {
        // TODO: Criar controles para paralelismo - Blocks and TimeOuts
        if (Head is null)
            return null;
        
        var currentHead = Head;
        Head = Head.Next;
        
        return currentHead;
    }

    public MyNode<T>? Peek()
    {
        return Head;
    }
}