using System;
using System.Text.Json;
using Problems.ADT;
using Problems.BinaryTree;

namespace Problems;

public class Program
{
    public static void Main(string[] args)
    {
        Q347 q = new();

        TreeNode root = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));

        var res = q.TopKFrequent([1, 1, 1, 2, 2, 3], 2);

        Console.WriteLine(res);
        Console.WriteLine(JsonSerializer.Serialize(res));
    }
}