using System.Collections.Generic;
using Problems.ADT;

namespace Problems.BinaryTree;

public class Q94
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> list = [];

        InorderTraversal(root, list);

        return list;
    }

    private void InorderTraversal(TreeNode node, List<int> list)
    {
        if (node == null)
        {
            return;
        }

        InorderTraversal(node.left, list);
        list.Add(node.val);
        InorderTraversal(node.right, list);
    }
}