using System;

namespace Problems;

public class Program
{
    public static void Main(string[] args)
    {
        P300 p = new();
        Console.WriteLine(p.LengthOfLIS([10, 9, 2, 5, 3, 7, 101, 18]));

    }
}