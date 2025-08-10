using System;
using System.Collections.Generic;

namespace Problems;

public class Q3
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length < 2) return s.Length;

        int i = 0, j = 0;

        HashSet<char> appeared = [];

        int max = 0;

        Dictionary<char, int> lastCharIndex = [];

        while (i < s.Length && j < s.Length)
        {
            if (appeared.Add(s[j]))
            {
                max = Math.Max(max, appeared.Count);
                j++;
            }
            else
            {
                i = lastCharIndex[s[j]] + 1;
            }

            lastCharIndex[s[j]] = i;
        }

        return max;
    }
}