using System;
using System.Collections.Generic;

namespace Problems;

public class P1
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numIndex = [];

        for (int i = 0; i < nums.Length; i++)
        {
            if (numIndex.TryGetValue(target - nums[i], out int index))
            {
                return [index, i];
            }

            numIndex[nums[i]] = i;
        }

        throw new ArgumentException();
    }
}