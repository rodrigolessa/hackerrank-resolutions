namespace DSA.MyDataStructures;

public class MyMaxHeap<T> where T : IComparable<T>
{
    private List<T> _heap = new List<T>();
    
    private int LeftChild(int index) => index * 2 + 1;
    private int RightChild(int index)=> index * 2 + 2;
    private int Parent(int index) => (index - 1) / 2;

    private void HeapifyUp(int index)
    {
        // Sobe cada level até chegar no 0 onde não é preciso fazer operações e sai da recursividade
        if (index == 0) return;

        int parentIndex = Parent(index);

        if (_heap[index].CompareTo(_heap[parentIndex]) > 0)
        {
            (_heap[parentIndex], _heap[index]) = (_heap[index], _heap[parentIndex]);
            HeapifyUp(parentIndex);
        }
    }

    private void HeapifyDown(int index)
    {
        // Para verificar se a posição é maior que o tamanho do heap para verificar se chegou em uma folha e sair da recursividade
        int size = _heap.Count;
        int smallestValueIndex = index;
        int leftChild = LeftChild(index);
        int rightChild = RightChild(index);

        if (leftChild < size && _heap[smallestValueIndex].CompareTo(_heap[leftChild]) < 0)
            smallestValueIndex = leftChild;
        
        if (rightChild < size && _heap[smallestValueIndex].CompareTo(_heap[rightChild]) < 0)
            smallestValueIndex = rightChild;

        if (smallestValueIndex != index)
        {
            (_heap[smallestValueIndex], _heap[index]) = (_heap[index], _heap[smallestValueIndex]);
            HeapifyDown(smallestValueIndex);    
        }
    }

    public void Insert(T value)
    {
        _heap.Add(value);
        HeapifyUp(_heap.Count - 1);
    }

    public T? Peek()
    {
        if (_heap.Count == 0)
            return default;
        
        return _heap[0];
    }

    public T? Pop()
    {
        int lastPosition = _heap.Count - 1;
        if (lastPosition < 0)
            return default;

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

    public T[] ToArray()
    {
        return _heap.ToArray();
    }
}