using DSA.MyDataStructures;
using DSA.MyDataStructures.LeetCodeStructures;

namespace DSA.GetHandsDirty.DynamicProgrammingTecnique;

/// <summary>
/// LeetCode 146
/// Design a data structure that follows the constraints of a Least Recently Used (LRU) cache.
/// </summary>
public class LRUCache
{
    public class UNode
    {
        public int Key { get; set; }
        public int Value { get; set; }
        public UNode? Previous { get; set; }
        public UNode? Next { get; set; }

        public UNode(int key, int val)
        {
            Key = key;
            Value = val;
        }
    }

    private readonly int _capacity;
    private Dictionary<int, UNode> _fastAccessCache;
    private UNode _dummyHead;
    private UNode _dummyTail;

    public LRUCache(int capacity)
    {
        _capacity = capacity;
        _fastAccessCache = new Dictionary<int, UNode>();
        _dummyHead = new UNode(0, 0);
        _dummyTail = new UNode(0, 0);
        _dummyHead.Next = _dummyTail;
        _dummyTail.Previous = _dummyHead;
    }

    private static void Remove(UNode current)
    {
        var before = current.Previous;
        var after = current.Next;

        // Remove node from ordered linked list
        before.Next = after;
        after.Previous = before;
    }

    private void Insert(UNode current)
    {
        var trueHead = _dummyHead.Next;
        trueHead.Previous = current;

        _dummyHead.Next = current;
        current.Previous = _dummyHead;
        current.Next = trueHead;
    }

    public int Get(int key)
    {
        if (!_fastAccessCache.TryGetValue(key, out UNode current))
            return -1;

        Remove(current);
        Insert(current);

        return current.Value;
    }

    public void Put(int key, int value)
    {
        if (_fastAccessCache.TryGetValue(key, out UNode current))
            Remove(current);
        var newNode = new UNode(key, value);
        // Sempre insere no início da lista pois foi o último visitado
        Insert(newNode);
        _fastAccessCache[key] = newNode;

        while (_fastAccessCache.Count > _capacity)
        {
            // TODO: Remove last seen
            var trueTail = _dummyTail.Previous;
            Remove(trueTail);
            _fastAccessCache.Remove(trueTail.Key);
        }
    }
}