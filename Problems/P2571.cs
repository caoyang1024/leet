using System;

namespace Problems;

/// <summary>
/// 2571. Minimum Operations to Reduce an Integer to 0
/// </summary>
public class P2571
{
    public int MinOperations(int n)
    {
        // base case
        if (IsPowerOf2(n)) return 1;

        int prev = FindPreviousPowerOf2(n);
        int next = FindNextPowerOf2(n);

        if (Math.Pow(2, next) - n < n - Math.Pow(2, prev))
        {
            return 1 + MinOperations((int)Math.Pow(2, next) - n);
        }
        else
        {
            return 1 + MinOperations(n - (int)Math.Pow(2, prev));
        }
    }

    public bool IsPowerOf2(int n)
    {
        int log = (int)Math.Log2(n);

        return (int)Math.Pow(2, log) == n;
    }

    public int FindPreviousPowerOf2(int n)
    {
        return (int)Math.Log2(n);
    }

    public int FindNextPowerOf2(int n)
    {
        return (int)(Math.Log2(n) + 1);
    }
}