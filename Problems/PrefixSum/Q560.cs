using System;
using System.Collections.Generic;

namespace Problems.PrefixSum;

public class Q560
{
    public int SubarraySum(int[] nums, int k)
    {
        int result = SS(nums, k);
        Console.WriteLine($"\nTotal subarrays with sum = {k}: {result}");
        return result;
    }

    private int SS(int[] nums, int k)
    {
        Dictionary<int, int> prefixCount = [];
        prefixCount[0] = 1;

        int sum = 0, count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            int target = sum - k;
            if (prefixCount.ContainsKey(target))
            {
                count += prefixCount[target];
                Console.WriteLine($"✅ Found match at index {i}: current_sum = {sum}, needed = {target}, freq = {prefixCount[target]}");
            }

            prefixCount.TryAdd(sum, 0);
            prefixCount[sum]++;

            Console.WriteLine($"Index {i}, Num = {nums[i]}, PrefixSum = {sum}, Count = {count}");
        }

        return count;
    }
}