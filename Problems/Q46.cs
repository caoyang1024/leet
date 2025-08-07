using System.Collections.Generic;
using System.Linq;

namespace Problems;

public class Q46
{
    public IList<IList<int>> Permute(int[] nums)
    {
        List<IList<int>> result = [];

        Backtracking(nums, new List<int>(), result, new HashSet<int>());

        return result;
    }

    private void Backtracking(int[] nums, List<int> list, List<IList<int>> result, HashSet<int> visited)
    {
        if (list.Count == nums.Length)
        {
            result.Add(new List<int>(list));
            return;
        }

        foreach (var n in nums)
        {
            if (visited.Contains(n))
            {
                continue;
            }

            list.Add(n);
            visited.Add(n);

            Backtracking(nums, list, result, visited);

            visited.Remove(list.Last());
            list.RemoveAt(list.Count - 1);
        }
    }
}