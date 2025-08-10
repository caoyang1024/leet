using System.Linq;

namespace Problems;

public class Q238
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int p = 1;
        int countZero = 0;

        foreach (var n in nums)
        {
            if (n == 0)
            {
                countZero++;
            }
            else
            {
                p *= n;
            }

            if (countZero >= 2)
            {
                return Enumerable.Repeat(0, nums.Length).ToArray();
            }
        }

        int[] result = new int[nums.Length];

        for (int i = 0; i < result.Length; i++)
        {
            if (nums[i] == 0)
            {
                result[i] = p;
            }
            else if (countZero == 1)
            {
                result[i] = 0;
            }
            else
            {
                result[i] = p / nums[i];
            }
        }

        return result;
    }
}