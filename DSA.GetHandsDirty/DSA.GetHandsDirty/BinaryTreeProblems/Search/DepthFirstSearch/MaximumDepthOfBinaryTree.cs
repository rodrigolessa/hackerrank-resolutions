using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.BinaryTreeProblems;

/// <summary>
/// LeetCode 104
/// </summary>
public class MaximumDepthOfBinaryTree
{
    public int MaxDepth(MyBinaryNode? root)
    {
        if (root is null)
            return 0;

        return DepthCount(root);
    }
    
    private int DepthCount(MyBinaryNode? root, int counter = 0)
    {
        if (root is null)
            return counter;

        counter++;
        
        return Math.Max(DepthCount(root.LeftChild, counter), DepthCount(root.RightChild, counter));
    }
    
    /// <summary>
    /// Another example
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int MaxDepthRecursive(MyBinaryNode? root) {
        if (root == null) return 0;
        return 1 + Math.Max(MaxDepthRecursive(root.LeftChild), MaxDepthRecursive(root.RightChild));
    }
}