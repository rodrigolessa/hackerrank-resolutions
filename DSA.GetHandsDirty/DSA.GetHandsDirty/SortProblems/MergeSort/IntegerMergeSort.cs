using DSA.GetHandsDirty.LinkedListProblems;
using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.SortProblems.MergeSort;

/// <summary>
/// Complexidade temporal  de O(n log(n))
/// </summary>
public static class IntegerMergeSort
{
    public static MyNode<int>? Sort(MyNode<int>? head)
    {
        if (head?.Next is null)
        {
            return head;
        }
        
        // Primeiro precisamos encontar o meio da lista para dividir em duas metades
        // Isso vai ser de maneira recursiva
        var theMiddle = FindTheMiddle(head);
        var afterMiddle = theMiddle.Next;
        // Quebrar o link do meio para dividir a lista
        theMiddle.Next = null;
        
        // Chamada recursiva para quebrar a lista até sobre somente nós isolados
        var left = Sort(head);
        var right = Sort(afterMiddle);
        
        var sorted = Merge(left, right);

        return sorted;
    }

    /// <summary>
    /// The input is two parts of a list que foi dividida em um passo anterior
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    private static MyNode<int>? Merge(MyNode<int>? left, MyNode<int>? right)
    {
        // Start with an empty list. It will be discarded at the end of algorithm
        var head = new MyNode<int>(0);
        var tail = head; // O tail é meu ponteiro a cada iteração eu devo mover para o próximo 

        // Percorrer as duas listas para verificar se a ordem está correta?
        while (left is not null && right is not null)
        {
            // Se o primeiro nó da esquerda for menor que o primeiro da direita
            if (left.Value < right.Value)
            {
                // Inicia nossa lista vazia com esse nó
                // Lembrando que o primeiro item vazio vai ser descartado, por isso atribuimos ao "Next"
                tail.Next = left;
                // Move para o próximo item da lista
                left = left.Next;
            }
            else
            {
                // Se o da direita for o menor, ele inicia a lista
                tail.Next = right;
                // Move para o próximo item da lista, se não existir o right fica nulo e termina o while
                right = right.Next;
            }
            
            // Move o valor ordenado para a última posição lista
            tail = tail.Next;
        }
        
        // Agora move (merge) o valor que sobrou, ou seja a lista que já está ordenada
        // para o final da lista, criando um novo "Tail"
        // Se o tail possui um "Next" ele não é mais o "Tail" na verdade
        tail.Next = left ?? right;

        // O retorna o primeiro intem da lista ordenada que possui valor, descartando o vazio
        return head.Next;
    }
    
    private static MyNode<int> FindTheMiddle(MyNode<int> head)
    {
        var slow = head;
        var fast = head.Next;
        while (fast?.Next is not null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
        }

        return slow;
    }
}