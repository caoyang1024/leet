using System.Collections.Generic;

namespace Problems.PrefixSum;

public class Q560
{
    public int SubarraySum(int[] nums, int k)
    {
        Dictionary<int, int> prefixCount = [];

        prefixCount[0] = 1;

        int sum = 0, count = 0;

        foreach (var n in nums)
        {
            sum += n;

            int target = sum - k;
            if (prefixCount.TryGetValue(target, out var value))
            {
                count += value;
            }

            prefixCount.TryAdd(sum, 0);
            prefixCount[sum]++;
        }

        return count;
    }
}