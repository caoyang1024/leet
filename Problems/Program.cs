using System;

namespace Problems;

public class Program
{
    public static void Main(string[] args)
    {
        P735 p735 = new P735();
        int[] arr = p735.AsteroidCollision([1, -2, -2, -2]);

        foreach (var i in arr)
        {
            Console.Write(i + ", ");
        }
    }
}