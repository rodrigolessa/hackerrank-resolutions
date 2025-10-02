using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.BinaryTreeProblems.Search.DepthFirstSearch;

/// <summary>
/// Busca em profundidade
/// LeetCode 112 - DFS
/// Buscar recursivamente os nodes até chegar a uma folha e verificar se a subtração do target é igual a zero;
/// </summary>
public class FindIfHasAPathSumSolution
{
    public bool HasPathSum(MyBinaryNode? root, int targetSum)
    {
        if (root is null)
            return false;

        if (root.LeftChild is null && root.RightChild is null && root.Data == targetSum)
            return true;

        return HasPathSum(root.LeftChild, targetSum - root.Data) || HasPathSum(root.RightChild, targetSum - root.Data);
    }
}