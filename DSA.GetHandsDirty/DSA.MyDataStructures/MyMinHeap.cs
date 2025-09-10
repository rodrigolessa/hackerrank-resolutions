using System.Xml.Schema;

namespace DSA.MyDataStructures;

/// <summary>
/// Binary Heap or Priority queue
/// Segue uma ordenação baseado em alguma regra (muito semelhante ao uma binary tree):
/// Min heap:
/// - o root é sempre o menor valor e,
///     - todos os valores imediatamente abaixo de qualquer nó devem ser maiores ou iguais ao mesmo
/// - Se tentar inserir um valor menor, este deve ser reordenado até ficar em uma posição correta
/// - Outra regra é que todos os elementos devem ser adicionados da esquerda para a direita
/// Max heap:
/// -
/// Mesmo sendo semelhante a uma árvore binária a forma tradicional de se armazenar um heap é em um array
/// - usando uma formula para acessar seu índice:
///     - posição à esquerda (index * 2 + 1)
///     - posição à direita (index * 2 + 2)
/// </summary>
public class MyMinHeap<T> where T : IComparable<T>
{
    // The standard implement involve an array to hold the elements,
    // but in C# an array has a fixed size,
    // therefor we cannot append new element at the end.
    // Then let's make use of a structure that internally uses an array but is dynamic  
    private List<T> _heap = new List<T>();

    private int LeftChildIndex(int index) => index * 2 + 1;
    private int RightChildIndex(int index) => index * 2 + 2;

    private int ParentIndex(int index) => (index - 1) / 2;

    private void HeapifyUp(int index)
    {
        if (index == 0) return;

        int parentIndex = ParentIndex(index);

        if (_heap[index].CompareTo(_heap[parentIndex]) < 0)
        {
            // If heap value is less than its parent, swap position in-place
            (_heap[index], _heap[parentIndex]) = (_heap[parentIndex], _heap[index]);
            HeapifyUp(parentIndex);
        }
    }

    private void HeapifyDown(int index)
    {
        int size = _heap.Count;
        int childLeft = LeftChildIndex(index);
        int childRight = RightChildIndex(index);
        int biggest = index;
        if (childLeft < size && _heap[biggest].CompareTo(_heap[childLeft]) > 0)
            biggest = childLeft;

        if (childRight < size && _heap[biggest].CompareTo(_heap[childRight]) > 0)
            biggest = childRight;

        if (biggest != index)
        {
            (_heap[index], _heap[biggest]) = (_heap[biggest], _heap[index]);
            HeapifyDown(biggest);
        }
    }

    public T[] ToArray()
    {
        return _heap.ToArray();
    }

    public void Print()
    {
        Console.Write(_heap);
    }

    public void Insert(T value)
    {
        _heap.Add(value);
        HeapifyUp(_heap.Count - 1);
    }

    public T? Peek()
    {
        return _heap.Count == 0 ? default(T) : _heap[0];
    }

    public T? Pop()
    {
        var lastPosition = _heap.Count - 1;
        if (lastPosition < 0)
            return default(T);

        var root = _heap[0];

        if (lastPosition == 0)
        {
            _heap.RemoveAt(0);
            return root;
        }
        
        _heap[0] = _heap[lastPosition];
        _heap.RemoveAt(lastPosition);
        HeapifyDown(0);

        return root;
    }
}