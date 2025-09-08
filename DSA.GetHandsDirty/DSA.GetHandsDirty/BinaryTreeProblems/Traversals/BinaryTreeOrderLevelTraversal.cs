using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.BinaryTreeProblems;

/// <summary>
/// LeetCode 102
/// É a mesma implementação e problema semelhante ao BFS.
/// A diferença é que dentro do loop principal precisamos percorrer todo o nível antes de passar para a próxíma iteração
/// </summary>
public class BinaryTreeOrderLevelTraversal
{
    public IList<IList<int>> LevelOrder(MyBinaryNode? root)
    {
        if (root is null)
            return new List<IList<int>>();

        var r = new List<IList<int>>();

        var q = new Queue<MyBinaryNode>();
        q.Enqueue(root);
        
        while (q.Count > 0)
        {
            var level = new List<int>();
            var levelSize = q.Count;

            foreach (var i in Enumerable.Range(1, levelSize))
            {
                var currentNode = q.Dequeue();
                if (currentNode?.Data is not null)
                {
                    level.Add(currentNode.Data);
                    if (currentNode.LeftChild is not null)
                        q.Enqueue(currentNode.LeftChild);
                    if (currentNode.RightChild is not null)
                        q.Enqueue(currentNode.RightChild);
                }
            }

            if (level.Count > 0)
                r.Add(level);
        }
        
        return r;
    }
}