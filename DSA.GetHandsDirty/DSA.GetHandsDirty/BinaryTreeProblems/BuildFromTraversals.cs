using DSA.MyDataStructures;

namespace DSA.GetHandsDirty.BinaryTreeProblems;

public class BuildFromTraversals
{
    int postIdx, inIdx;
    int[] inorder, postorder;

    public MyBinaryNode BuildTree(int[] inorder, int[] postorder) {
        this.inorder = inorder;
        this.postorder = postorder;
        postIdx = inIdx = postorder.Length - 1;
        return Dfs(int.MaxValue);
    }

    private MyBinaryNode Dfs(int limit) {
        if (postIdx < 0) return null;
        if (inorder[inIdx] == limit) {
            inIdx--;
            return null;
        }

        MyBinaryNode root = new MyBinaryNode(postorder[postIdx--]);
        root.RightChild = Dfs(root.Data);
        root.LeftChild = Dfs(limit);
        return root;
    }
}