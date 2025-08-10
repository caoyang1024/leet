using System;
using System.Linq;

namespace Problems.DP;

public class Q45
{
    /*=====================================
     *
     * 45: Jump Game II
     * Stars: ⭐⭐⭐⭐
     * Difficulty: Medium
     * My Difficulty: Easy - Medium
     * DP
     * O(n)
     *
     =====================================*/
    public int Jump(int[] nums)
    {
        // use int.MaxValue to indicate not reachable
        int[] minSteps = Enumerable.Repeat(int.MaxValue, nums.Length).ToArray();

        minSteps[nums.Length - 1] = 0;

        for (int i = nums.Length - 2; i >= 0; i--)
        {
            for (int j = nums[i]; j >= 1; j--)
            {
                if (i + j < nums.Length && minSteps[i + j] != int.MaxValue)
                {
                    minSteps[i] = Math.Min(minSteps[i], 1 + minSteps[i + j]);
                }
            }
        }

        if (minSteps[0] == int.MaxValue) throw new ArgumentException();

        return minSteps[0];
    }
}