using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.BinaryTreeProblems;

/// <summary>
/// LeetCode 100
/// </summary>
public class SameTreeProblem
{
    public bool IsSameTree(MyBinaryNode p, MyBinaryNode q)
    {
        if (p?.Data is null || q?.Data is null)
            return true;
        
        return IsSameNodeValue(p, q);
    }

    private bool IsSameNodeValue(MyBinaryNode? p, MyBinaryNode? q)
    {
        if (p is null && q is null)
            return true;
        
        if (p?.Data != q?.Data)
            return false;

        var isSameLeft = IsSameNodeValue(p?.LeftChild, q?.LeftChild);
        var isSameRight = IsSameNodeValue(p?.RightChild, q?.RightChild);
        
        return isSameLeft && isSameRight;
    }
}