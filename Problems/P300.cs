using System;
using System.Linq;

namespace Problems;

public class P300
{
    public int LengthOfLIS(int[] nums)
    {
        int[] longest = Enumerable.Repeat(1, nums.Length).ToArray();

        for (int i = 1; i < nums.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[j] < nums[i])
                {
                    longest[i] = Math.Max(longest[i], longest[j] + 1);
                }
            }
        }

        return longest.Max();
    }
}