using System;
using Problems.ADT;
using Problems.SlidingWindow;

namespace Problems;

public class Program
{
    public static void Main(string[] args)
    {
        Q1438 q = new();

        TreeNode root = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));

        var res = q.LongestSubarray([1, 5, 6, 7, 8, 10, 6, 5, 6], 4);

        Console.WriteLine(res);
    }
}