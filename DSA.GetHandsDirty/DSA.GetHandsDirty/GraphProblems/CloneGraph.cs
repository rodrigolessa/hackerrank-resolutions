using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.GraphProblems;

/// <summary>
/// LeetCode 133
/// Essa forma de grafo é bem semelhante a uma tree que fizemos e por isso faz sentido utilizar BFS
/// Usa uma estrutura (um dictionary - O(1)) para verificas se o nó já foi visitado e,
/// add em nossa queue que sejá nossa estrutura de controle da BFS
/// </summary>
public class CloneGraph
{
    public MyGraphNode Clone(MyGraphNode? node)
    {
        if (node == null)
            return new MyGraphNode();
        
        var clones = new Dictionary<int, MyGraphNode>();
        var queue = new Queue<MyGraphNode>();
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            var original = queue.Dequeue();
            var currentClone = new MyGraphNode(original.val);

            foreach (var neighbor in original.neighbors)
            {
                if (clones.ContainsKey(neighbor.val))
                {
                    currentClone.neighbors.Add(clones[neighbor.val]);
                }
                else
                {
                    clones[neighbor.val] = new MyGraphNode(neighbor.val);
                    queue.Enqueue(neighbor);
                }
            }
            
            clones.Add(currentClone.val, currentClone);
        }

        return clones[node.val];
    }
}