namespace DSA.MyDataStructures;

public class MyBinaryNode(int data)
{
    public int Data { get; } = data;
    public MyBinaryNode? LeftChild { get; set; } = null;
    public MyBinaryNode? RightChild { get; set; } = null;
}