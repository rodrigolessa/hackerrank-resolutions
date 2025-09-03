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

    #region Searching

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
    
    #endregion
    
    #region Traversal methods
    
    /// <summary>
    /// Usar uma técnica de backtracking, passar o resultado como referência para apendar enquanto desmonta a call stack
    /// </summary>
    /// <returns></returns>
    public IEnumerable<int> PreorderTraversal()
    {
        var preorder = new List<int>();
        if (Root is null)
            return [];
        
        PreorderTraversalRecursively(Root, preorder);

        return preorder;
    }
    
    private void PreorderTraversalRecursively(MyBinaryNode? node, List<int> preorder)
    {
        if (node is null)
            return;

        preorder.Add(node.Data);
        PreorderTraversalRecursively(node.LeftChild, preorder);
        PreorderTraversalRecursively(node.RightChild, preorder);
    }
    
    /// <summary>
    /// If the tree is balanced the root should be at the middle of the array
    /// </summary>
    /// <returns></returns>
    public IEnumerable<int> InorderTraversal()
    {
        var inorder = new List<int>();
        if (Root is null)
            return [];
        
        InorderTraversalRecursively(Root, inorder);

        return inorder;
    }
    
    private void InorderTraversalRecursively(MyBinaryNode? node, List<int> inorder)
    {
        if (node is null)
            return;
        
        InorderTraversalRecursively(node.LeftChild, inorder);
        inorder.Add(node.Data);
        InorderTraversalRecursively(node.RightChild, inorder);
    }
    
    /// <summary>
    /// Root is the last in the array result
    /// A intenção é liberar a call stack o mais rápido possível
    /// </summary>
    /// <returns></returns>
    public IEnumerable<int> PostOrderTraversal()
    {
        var postorder = new List<int>();
        if (Root is null)
            return [];
        
        PostOrderTraversalRecursively(Root, postorder);

        return postorder;
    }
    
    private void PostOrderTraversalRecursively(MyBinaryNode? node, List<int> postorder)
    {
        if (node is null)
            return;
        
        PostOrderTraversalRecursively(node.LeftChild, postorder);
        PostOrderTraversalRecursively(node.RightChild, postorder);
        postorder.Add(node.Data);
    }
    
    #endregion
}