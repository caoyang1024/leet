using System;
using System.Text.Json;
using Problems.ADT;
using Problems.BinaryTree;

namespace Problems;

public class Program
{
    public static void Main(string[] args)
    {
        Q98 q = new();

        TreeNode root = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));

        Console.WriteLine(JsonSerializer.Serialize(q.IsValidBST(root)));
    }
}