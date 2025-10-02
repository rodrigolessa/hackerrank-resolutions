using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.BinaryTreeProblems.Traversals;

/// <summary>
/// LeetCode 106
/// Postorder = Left → Right → Root → (last element is always the root).
/// Inorder = Left → Root → Right → (use this to find left/right subtree boundaries).
/// 1 - Take the last element of postorder → this is the root.
/// 2 - Find its index in inorder → this splits the tree into left and right subtrees.
/// 3 - Recurse for the right subtree first, then the left subtree (because in postorder, we process right subtree before left when iterating backward).
/// </summary>
public class BuildATreeFromInorderAndPostorderTraversals
{
    private readonly Dictionary<int, int> _inorderIndexMap = new();
    private int _postorderIndex;

    public MyBinaryNode? BuildTree(int[] inorder, int[] postorder)
    {
        if (inorder.Length == 0 || postorder.Length == 0)
            return null;
        
        // Map each value to its index in inorder for O(1) lookups
        for (int i = 0; i < inorder.Length; i++)
            _inorderIndexMap[inorder[i]] = i;
        
        // The last element in postorder is always the root
        _postorderIndex = postorder.Length - 1;
        return Build(inorder, postorder, 0, inorder.Length - 1);
    }

    // Um Array em C# tem tamanho fixo, uma vez criado só podemos recriar usando a função .Resize(ref old array, new length)
    // Mas como não é muito eficiente tentar remover o último elemento em cada iteração
    // Podemos otimizar o desempenho fazendo o uso da técnica Two Pointers
    private MyBinaryNode? Build(int[] inorder, int[] postorder, int left, int right)
    {
        if (left > right)
            return null;
        
        // Get the current root node from postorder rightmost element
        // It will give us the correct right nodes
        int rootData = postorder[_postorderIndex--];
        MyBinaryNode root = new MyBinaryNode(rootData);
        
        // Find the element in inorder array to split in right and left based in the current root 
        int inorderIndex = _inorderIndexMap[rootData];

        root.RightChild = Build(inorder, postorder, inorderIndex + 1, right);
        root.LeftChild = Build(inorder, postorder, left, inorderIndex - 1);
        
        return root;
    }
}