namespace DSA.MyDataStructures.Abstractions;

public interface IMyLinkedList<T>
{
    MyNode<T>? Head { get; set; }
    MyNode<T>? Tail { get; set; }

    IMyLinkedList<T> AddInFirstPosition(T value);
    IMyLinkedList<T> AddInLastPosition(T value);
    T? RemoveFirstPosition();
    T? RemoveLastPosition();
    int HowMany();
    void Reverse();
}