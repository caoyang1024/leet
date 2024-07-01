using System;
using System.Collections.Generic;

namespace Problems;

/// <summary>
/// 735. Asteroid Collision
/// 2024-07-01
/// </summary>
public class P735
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        Stack<int> stack = new Stack<int>();

        foreach (var asteroid in asteroids)
        {
            if (stack.Count > 0 && stack.Peek() > 0 && asteroid < 0)
            {
                while (true)
                {
                    if (stack.Count == 0)
                    {
                        stack.Push(asteroid);
                        break;
                    }

                    if (SameDirection(stack.Peek(), asteroid))
                    {
                        stack.Push(asteroid);
                        break;
                    }
                    if (stack.Peek() > Math.Abs(asteroid))
                    {
                        break;
                    }

                    if (stack.Peek() < Math.Abs(asteroid))
                    {
                        stack.Pop();
                    }
                    else if (stack.Peek() == Math.Abs(asteroid))
                    {
                        stack.Pop();
                        break;
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
            else
            {
                stack.Push(asteroid);
            }
        }

        int[] arr = new int[stack.Count];
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            arr[i] = stack.Pop();
        }

        bool SameDirection(int x, int y)
        {
            return (x > 0 && y > 0) || (x < 0 && y < 0);
        }

        return arr;
    }
}