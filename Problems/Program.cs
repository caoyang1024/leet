using System;
using System.Text.Json;

namespace Problems;

public class Program
{
    public static void Main(string[] args)
    {
        Q131 q = new();
        Console.WriteLine(JsonSerializer.Serialize(q.Partition("aab")));
    }
}