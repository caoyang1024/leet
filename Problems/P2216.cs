namespace Problems;

/// <summary>
/// 2216. Minimum Deletions to Make Array Beautiful
/// </summary>
public class P2216
{
    public int MinDeletion(int[] nums)
    {
        if (nums.Length == 1) return 1;
        return MinDeletion(nums, 0, 1, true, 0);
    }

    private int MinDeletion(int[] nums, int leftIndex, int rightIndex, bool isEvenIndex, int deleted)
    {
        if (leftIndex >= nums.Length) return 0;
        if (rightIndex >= nums.Length) return 1;
        if (leftIndex == nums.Length - 1 && (nums.Length - deleted) % 2 == 0) return 0;
        if (leftIndex == nums.Length - 1) return 1;

        if (isEvenIndex)
        {
            if (nums[leftIndex] == nums[rightIndex])
            {
                return 1 + MinDeletion(nums, leftIndex, rightIndex + 1, true, deleted + 1);
            }
        }

        return MinDeletion(nums, rightIndex + 1, rightIndex + 2, true, deleted);
    }
}