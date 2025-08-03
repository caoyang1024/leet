using System;
using System.Collections.Generic;

namespace Problems;

public class P1
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numIndices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (numIndices.TryGetValue(target - nums[i], out int index))
            {
                return [index, i];
            }

            numIndices[nums[i]] = i;
        }

        throw new ArgumentException();
    }
}