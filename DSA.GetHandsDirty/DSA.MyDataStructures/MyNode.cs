namespace DSA.MyDataStructures;

public class MyNode<T>(T value)
{
    public T Value { get; set; } = value;
    public MyNode<T>? Previous { get; set; }
    public MyNode<T>? Next { get; set; }
}