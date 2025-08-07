using System;
using System.Text.Json;

namespace Problems;

public class Program
{
    public static void Main(string[] args)
    {
        Q46 q = new();
        Console.WriteLine(JsonSerializer.Serialize(q.Permute([1, 2, 3])));
    }
}