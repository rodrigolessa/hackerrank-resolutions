namespace DSA.MyDataStructures;

public class MyBinaryNode(int data)
{
    public int Data { get; } = data;
    public MyBinaryNode? LeftChild { get; set; } = null;
    public MyBinaryNode? RightChild { get; set; } = null;
}

public class MyBinaryTree
{
    public MyBinaryNode? Root { get; private set; }

    public void Insert(int data)
    {
        if (Root is null)
        {
            Root = new MyBinaryNode(data);
            return;
        }

        InsertRecursively(data, Root);
    }

    private void InsertRecursively(int data, MyBinaryNode parentNode)
    {
        if (data > parentNode.Data)
        {
            if (parentNode.RightChild is null)
            {
                parentNode.RightChild = new MyBinaryNode(data);
                return;
            }
            
            InsertRecursively(data, parentNode.RightChild);
        }
        else
        {
            if (parentNode.LeftChild is null)
            {
                parentNode.LeftChild = new MyBinaryNode(data);
                return;
            }
        
            InsertRecursively(data, parentNode.LeftChild);   
        }
    }

    public MyBinaryNode? Search(int data)
    {
        return SearchRecursively(data, Root);
    }

    private static MyBinaryNode? SearchRecursively(int data, MyBinaryNode? currentNode)
    {
        if (currentNode is null)
            return null;

        if (currentNode.Data == data)
            return currentNode;

        return SearchRecursively(data, data > currentNode.Data ? currentNode.RightChild : currentNode.LeftChild);
    }
}