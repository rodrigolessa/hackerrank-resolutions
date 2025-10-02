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
        if (node is null)
            return new MyGraphNode();
        
        if (node.neighbors.Count == 0)
            return new MyGraphNode(node.val);
        
        var clones = new Dictionary<int, MyGraphNode> { { node.val, new MyGraphNode(node.val) } };
        var seem = new Queue<MyGraphNode>();
        seem.Enqueue(node);

        while (seem.Count > 0)
        {
            // Remover os nodes visitados da lista para inserir seus vizinhos
            var original = seem.Dequeue();
            var currentClone = clones[original.val];

            foreach (var neighbor in original.neighbors)
            {
                if (clones.TryAdd(neighbor.val, new MyGraphNode(neighbor.val)))
                    seem.Enqueue(neighbor);
                
                currentClone.neighbors.Add(clones[neighbor.val]);
            }
        }

        return clones.FirstOrDefault().Value;
    }
}