using System;

namespace Problems;

public class Program
{
    public static void Main(string[] args)
    {
        P62 p62 = new P62();
        Console.WriteLine(p62.UniquePaths(51, 9));
    }
}