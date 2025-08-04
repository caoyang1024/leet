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
        // if travel to the bottom or rightmost position, then 1
        if (currentM == m || currentN == n)
        {
            return 1;
        }

        if (_cache.TryGetValue((currentM, currentN), out int num))
        {
            return num;
        }

        int cnt = UniquePaths(m, n, currentM + 1, currentN) + UniquePaths(m, n, currentM, currentN + 1);

        _cache[(currentM, currentN)] = cnt;

        return cnt;
    }
}