using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.BinaryTreeProblems.Search.BreadthFirstSearch;

/// <summary>
/// Busca em amplitude
/// Percorrer a arvore por níveis, percorrendo lateralmente
/// Leet code
/// Usar uma DoublyQueue e enquanto existir item na fila adiciona os filhos e verifica o item
/// </summary>
public class BreadthFirstSearchTree
{
    public bool Find(MyBinaryNode? root, int data)
    {
        if (root is null)
            return false;
        
        var queue = new Queue<MyBinaryNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();
            if (currentNode.Data == data)
                return true;
            
            if (currentNode.LeftChild is not null)
                queue.Enqueue(currentNode.LeftChild);
            
            if (currentNode.RightChild is not null)
                queue.Enqueue(currentNode.RightChild);
        }   
        
        return false;
    }
}