using System;
using System.Collections.Generic;

namespace Problems.Backtrack;

public class Q78
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        var span = nums.AsSpan();

        var result = new List<IList<int>>();

        Subsets(span, 0, [], result);

        return result;
    }

    private void Subsets(ReadOnlySpan<int> span, int start, List<int> list, List<IList<int>> result)
    {
        result.Add(new List<int>(list));

        for (var i = start; i < span.Length; i++)
        {
            list.Add(span[i]);

            Subsets(span, i + 1, list, result);

            list.RemoveAt(list.Count - 1);
        }
    }
}