using System;

namespace Problems;

public class Program
{
    public static void Main(string[] args)
    {
    }

    /// <summary>
    /// 2024-06-26
    /// </summary>
    public static void RunP2571()
    {
        P2571 p2571 = new P2571();
        int num = p2571.MinOperations(33);
        Console.WriteLine(num);
    }
}