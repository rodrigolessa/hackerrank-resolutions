using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.UnitTests;

public static class DummyData
{
    public static MyBinaryTree GetMyFourLevelsBinaryTree()
    {
        var tree = new MyBinaryTree();
        tree.Insert(5);
        tree.Insert(7);
        tree.Insert(9);
        tree.Insert(3);
        tree.Insert(10);
        tree.Insert(2);
        tree.Insert(1);
        tree.Insert(8);

        return tree;
    }
}