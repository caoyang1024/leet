using System;
using System.Collections.Generic;

namespace Problems.SlidingWindow;

public class Q1438
{
    /*=====================================
     *
     * 1438: Longest Continuous Subarray With Absolute Diff Less Than or Equal to Limit
     * Stars: ⭐⭐⭐
     * Difficulty: Hard
     * My Difficulty: Hard
     * Sliding Window
     * Monotonic Queue / Deque
     * O(n)
     *
     =====================================*/

    public int LongestSubarray(int[] nums, int limit)
    {
        // FAILED DUE TO TIME COMPLEXITY

        int maxSize = 1;

        Dictionary<(int, int), int> rangeMax = [];

        for (int i = 0; i < nums.Length - 1; i++)
        {
            int min = nums[i];
            int max = nums[i];

            for (int j = i + 1; j < nums.Length; j++)
            {
                min = Math.Min(min, nums[j]);
                max = Math.Max(max, nums[j]);

                if (max - min <= limit)
                {
                    maxSize = Math.Max(maxSize, j - i + 1);
                    min = Math.Min(min, nums[j]);
                    max = Math.Max(max, nums[j]);
                }
                else
                {
                    break;
                }
            }
        }

        return maxSize;
    }
}