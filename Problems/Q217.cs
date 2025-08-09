using System.Collections.Generic;

namespace Problems;

public class Q217
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> hs = [];

        foreach (var num in nums)
        {
            if (hs.Add(num) == false)
            {
                return true;
            }
        }

        return false;
    }
}