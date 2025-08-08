using System.Collections.Generic;

namespace Problems;

public class Q347
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        HashSet<int>[] hsArr = new HashSet<int>[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            hsArr[i] = [];
        }

        Dictionary<int, int> numCount = [];

        foreach (var num in nums)
        {
            if (numCount.TryGetValue(num, out var currentCount))
            {
                hsArr[currentCount - 1].Remove(num);

                hsArr[currentCount].Add(num);

                numCount[num] = currentCount + 1;
            }
            else
            {
                hsArr[0].Add(num);
                numCount[num] = 1;
            }
        }

        int count2K = 0;

        List<int> result = [];

        for (int i = hsArr.Length - 1; i >= 0; i--)
        {
            foreach (var item in hsArr[i])
            {
                result.Add(item);
                count2K++;
            }

            if (count2K == k)
            {
                break;
            }
        }

        return result.ToArray();
    }
}