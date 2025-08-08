using System;
using System.Collections.Generic;

namespace Problems;

public class Q128
{
    public int LongestConsecutive(int[] nums)
    {
        int longest = 0;

        Dictionary<int, bool> mem = [];

        foreach (int num in nums)
        {
            mem[num] = false;
        }

        foreach (int num in nums)
        {
            if (mem[num] == false)
            {
                int leftCount = SearchLeft(num - 1);
                int rightCount = SearchRight(num + 1);

                mem[num] = true;

                longest = Math.Max(longest, leftCount + rightCount + 1);
            }
        }

        return longest;

        int SearchLeft(int n)
        {
            int total = 0;

            while (mem.ContainsKey(n))
            {
                mem[n] = true;
                total++;
                n--;
            }

            return total;
        }

        int SearchRight(int n)
        {
            int total = 0;

            while (mem.ContainsKey(n))
            {
                mem[n] = true;
                total++;
                n++;
            }

            return total;
        }
    }
}