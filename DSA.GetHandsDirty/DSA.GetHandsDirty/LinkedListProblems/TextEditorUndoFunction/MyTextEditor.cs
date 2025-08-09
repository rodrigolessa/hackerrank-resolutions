using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.LinkedListProblems.TextEditorUndoFunction;

/// <summary>
///  Real-World Problem: Undo/Redo Functionality
///     Imagine you’re building a simple text editor (or command system), and you want to implement undo/redo operations.
///     - Each node represents a state (or command).
///     - You can move backward (undo) and forward (redo) through the list.
///     - You can easily insert/remove nodes without shifting all elements (unlike arrays).
///  Why LinkedList Fits
///     - Undo → move to Previous
///     - Redo → move to Next
///     - Insert new command/state → truncate the list ahead of the current node, and insert new node at current
/// </summary>
public sealed class MyTextEditor
{
    private MyLinkedNode<string>? _currentContent = new ("");

    public string GetContent() => _currentContent.Value;

    public void WriteText(string newText)
    {
        var updated = string.Concat(_currentContent.Value, newText);
        var newEntry = new MyLinkedNode<string>(updated)
        {
            Previous = _currentContent
        };
        _currentContent.Next = newEntry;
        _currentContent = newEntry;
    }

    public void Undo()
    {
        if (_currentContent?.Previous is not null)
            _currentContent = _currentContent?.Previous;
    }

    public void Redo()
    {
        if (_currentContent?.Next is not null)
            _currentContent = _currentContent.Next;
    }
}