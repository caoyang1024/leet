using System;
using System.Collections.Generic;

namespace Problems;

public class Q15
{
    public IList<IList<int>> ThreeSum(int[] numbers)
    {
        Array.Sort(numbers);

        var list = new List<IList<int>>();

        HashSet<(int, int)> twoSum = new HashSet<(int, int)>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                return list;
            }

            if (i > 0 && numbers[i] == numbers[i - 1])
            {
                continue;
            }

            var twoSumList = TwoSum(i + 1, numbers.Length - 1, -numbers[i]);

            foreach (var pair in twoSumList)
            {
                list.Add([numbers[i], pair.Item1, pair.Item2]);
            }
        }

        return list;

        IEnumerable<(int, int)> TwoSum(int i, int j, int target)
        {
            twoSum.Clear();

            while (i < j)
            {
                if (numbers[i] + numbers[j] > target)
                {
                    j--;
                }
                else if (numbers[i] + numbers[j] < target)
                {
                    i++;
                }
                else
                {
                    if (twoSum.Add((numbers[i], numbers[j])))
                    {
                        yield return (numbers[i], numbers[j]);
                    }

                    i++;
                    j--;
                }
            }
        }
    }
}