namespace DSA.MyDataStructures.Abstractions;

public interface IMyLinkedList<T>
{
    MyLinkedNode<T>? Head { get; set; }
    MyLinkedNode<T>? Tail { get; set; }

    IMyLinkedList<T> AddInFirstPosition(T value);
    IMyLinkedList<T> AddInLastPosition(T value);
    T? RemoveFirstPosition();
    T? RemoveLastPosition();
    int HowMany();
    void Reverse();
}