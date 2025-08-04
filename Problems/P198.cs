using System;

namespace Problems;

public class P198
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];

        int[] f = new int[nums.Length + 1];

        f[1] = nums[0];
        f[2] = Math.Max(nums[0], nums[1]);

        for (int i = 3; i <= nums.Length; i++)
        {
            f[i] = Math.Max(f[i - 1], f[i - 2] + nums[i - 1]);
        }

        return f[nums.Length];
    }
}