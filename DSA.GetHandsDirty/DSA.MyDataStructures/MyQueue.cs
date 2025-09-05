namespace DSA.MyDataStructures;

/// <summary>
/// FIFO behavior (First-In-First-Out)
/// O padrão é implementado com uma linkedList
/// </summary>
public class MyQueue<T>
{
    public MyLinkedNode<T>? Head { get; set; }
    public MyLinkedNode<T>? Tail { get; set; }

    public void Enqueue(T item) // PUT - Insert at last position
    {
        if (Head is null)
            Head = new MyLinkedNode<T>(item);
        
        if (Tail is null)
            Tail = new MyLinkedNode<T>(item);
        else
        {
            Tail.Next = new MyLinkedNode<T>(item);
            Tail = Tail.Next;
        }
    }

    public MyLinkedNode<T>? Dequeue() // POP OR GET - Return first element and remove it;
    {
        // TODO: Criar controles para paralelismo - Blocks and TimeOuts
        if (Head is null)
            return null;
        
        var currentHead = Head;
        Head = Head.Next;
        
        return currentHead;
    }

    public MyLinkedNode<T>? Peek()
    {
        return Head;
    }
}