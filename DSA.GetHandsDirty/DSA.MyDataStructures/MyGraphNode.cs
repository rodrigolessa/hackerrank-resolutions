namespace DSA.MyDataStructures;

public class MyGraphNode
{
    public int val;
    public IList<MyGraphNode> neighbors;

    public MyGraphNode()
    {
        val = 0;
        neighbors = new List<MyGraphNode>();
    }

    public MyGraphNode(int _val)
    {
        val = _val;
        neighbors = new List<MyGraphNode>();
    }

    public MyGraphNode(int _val, List<MyGraphNode> _neighbors)
    {
        val = _val;
        neighbors = _neighbors;
    }
}