using System;

namespace Problems;

public class Program
{
    public static void Main(string[] args)
    {
        P322 p = new P322();
        Console.WriteLine(p.CoinChange([ 2], 3));
    }
}