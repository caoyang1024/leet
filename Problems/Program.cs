using System;
using Problems.ADT;
using Problems.PrefixSum;

namespace Problems;

public class Program
{
    public static void Main(string[] args)
    {
        Q560 q = new();

        TreeNode root = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));

        var res = q.SubarraySum([1, -1, -1, 2, 3, 2, 1, -1], 5);

        Console.WriteLine(res);
    }
}