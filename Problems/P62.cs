using System;
using System.Collections.Generic;

namespace Problems;

public class P62
{
    // recursion + memorization
    public int UniquePaths(int m, int n)
    {
        return UniquePaths(m, n, 1, 1);
    }

    private readonly Dictionary<(int, int), int> _cache = [];

    private int UniquePaths(int m, int n, int currentM, int currentN)
    {
        // if travel to the bottom right position, then return 1
        if (currentM == m && currentN == n)
        {
            return 1;
        }

        if (_cache.TryGetValue((currentM, currentN), out int num))
        {
            Console.WriteLine($"get from cache {currentM} {currentN}");
            return num;
        }

        // if at the bottom of the position, move right
        if (currentM == m)
        {
            int cntM = UniquePaths(m, n, currentM, currentN + 1);

            _cache[(currentM, currentN)] = cntM;

            return cntM;
        }

        // if at the rightmost position. move down
        if (currentN == n)
        {
            int cntN = UniquePaths(m, n, currentM + 1, currentN);

            _cache[(currentM, currentN)] = cntN;

            return cntN;
        }

        int cnt = UniquePaths(m, n, currentM + 1, currentN) + UniquePaths(m, n, currentM, currentN + 1);

        _cache[(currentM, currentN)] = cnt;

        return cnt;
    }
}