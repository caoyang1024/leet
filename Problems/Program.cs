using System;
using Problems.ADT;
using Problems.DP;

namespace Problems;

public class Program
{
    public static void Main(string[] args)
    {
        Q45 q = new();

        TreeNode root = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));

        Console.WriteLine(q.Jump([2, 1]));
        //Console.WriteLine(q.Jump([1]));
        //Console.WriteLine(q.Jump([2, 3, 1, 1, 4]));
        //Console.WriteLine(q.Jump([3, 2, 1, 0, 4]));
    }
}