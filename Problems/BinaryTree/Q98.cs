using System;
using Problems.ADT;

namespace Problems.BinaryTree;

public class Q98
{
    public bool IsValidBST(TreeNode root)
    {
        return IsValid(root, long.MinValue, long.MaxValue);
    }

    private bool IsValid(TreeNode node, long min, long max)
    {
        if (node == null) return true;

        if (node.val <= min || node.val >= max)
        {
            return false;
        }

        if (node.left != null && node.val <= node.left.val)
        {
            return false;
        }

        if (node.right != null && node.val >= node.right.val)
        {
            return false;
        }

        bool left = IsValid(node.left, min, Math.Min(max, node.val));

        if (left == false)
        {
            return false;
        }

        bool right = IsValid(node.right, Math.Max(min, node.val), max);

        if (right == false)
        {
            return false;
        }

        return true;
    }
}