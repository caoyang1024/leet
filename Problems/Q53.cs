using System;
using System.Linq;

namespace Problems;

public class Q53
{
    public int MaxSubArray(int[] nums)
    {
        int[] max = new int[nums.Length];
        max[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            max[i] = Math.Max(nums[i], nums[i] + max[i - 1]);
        }

        return max.Max();
    }
}