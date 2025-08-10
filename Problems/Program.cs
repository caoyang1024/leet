using System;
using Problems.ADT;
using Problems.DP;

namespace Problems;

public class Program
{
    public static void Main(string[] args)
    {
        Q55 q = new();

        TreeNode root = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));

        Console.WriteLine(q.CanJump([0, 1]));
        Console.WriteLine(q.CanJump([1]));
        Console.WriteLine(q.CanJump([2, 3, 1, 1, 4]));
        Console.WriteLine(q.CanJump([3, 2, 1, 0, 4]));
    }
}