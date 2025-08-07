using System.Collections.Generic;
using System.Linq;

namespace Problems;

public class Q77
{
    public IList<IList<int>> Combine(int n, int k)
    {
        var arr = Enumerable.Range(1, n).ToArray();

        List<IList<int>> result = [];

        Backtrack(arr, 0, k, [], result);

        return result;
    }

    private void Backtrack(int[] arr, int index, int k, List<int> list, List<IList<int>> result)
    {
        if (list.Count == k)
        {
            result.Add(new List<int>(list));
            return;
        }

        for (var i = index; i < arr.Length; i++)
        {
            list.Add(arr[i]);

            Backtrack(arr, i + 1, k, list, result);

            list.RemoveAt(list.Count - 1);
        }
    }
}