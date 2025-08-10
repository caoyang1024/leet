using System;
using System.Collections;
using System.Text.Json;
using Problems.ADT;
using Problems.QRT.ArrayPrefixSlidingWindow;

namespace Problems;

public class Program
{
    public static void Main(string[] args)
    {
        Q239 q = new();

        TreeNode root = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));

        var res = q.MaxSlidingWindow([1, 3, 1, 2, 0, 5], 3);

        if (res is IEnumerable e)
        {
            Console.WriteLine(JsonSerializer.Serialize(res));
        }
        else
        {
            Console.WriteLine(res);
        }
    }
}