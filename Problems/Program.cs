using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems;

public class Program
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);

        List<IList<int>> list = new List<IList<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                return list;
            }

            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            var twoSumList = TwoSum(nums, i + 1, nums.Length - 1, -nums[i]);

            foreach (var pair in twoSumList)
            {
                list.Add([nums[i], pair.Item1, pair.Item2]);
            }
        }

        return list;
    }

    private List<(int, int)> TwoSum(int[] nums, int i, int j, int target)
    {
        HashSet<(int, int)> twoSum = new HashSet<(int, int)>();

        while (i < j)
        {
            if (nums[i] + nums[j] > target)
            {
                j--;
            }
            else if (nums[i] + nums[j] < target)
            {
                i++;
            }
            else
            {
                twoSum.Add((nums[i], nums[j]));
                i++;
                j--;
            }
        }

        return twoSum.ToList();
    }
}