namespace DSA.MyDataStructures;

public class MyMinStack
{
    private List<int> _stack;
    private List<int> _minStack;
    private int _size;

    public MyMinStack() {
        _stack = new List<int>();
        _minStack = new List<int>();
    }
    
    public void Push(int val)
    {
        _stack.Add(val);
        if (_minStack.Count == 0)
            _minStack.Add(val);
        else
            _minStack.Add(Math.Min(val, _minStack[^1]));
        
        _size++;
    }
    
    public void Pop()
    {
        if (_stack.Count == 0)
            return;
        
        _stack.RemoveAt(_stack.Count - 1);
        _minStack.RemoveAt(_minStack.Count - 1);

        _size--;
    }
    
    public int Top() {
        return _stack[^1];
    }
    
    public int GetMin() {
        return _minStack[^1];
    }

    public int GetSize() => _size;
}