using System;
using System.Text.Json;
using Problems.ADT;
using Problems.BinaryTree;

namespace Problems;

public class Program
{
    public static void Main(string[] args)
    {
        Q128 q = new();

        TreeNode root = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));

        var res = q.LongestConsecutive([0, 3, 7, 2, 5, 8, 4, 6, 0, 1]);

        Console.WriteLine(res);
        Console.WriteLine(JsonSerializer.Serialize(res));
    }
}