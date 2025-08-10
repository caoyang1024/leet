namespace Problems.DP;

public class Q55
{
    /*=====================================
     *
     * 55: Jump Game
     * Stars: ⭐⭐⭐⭐
     * Difficulty: Medium
     * My Difficulty: Easy
     * DP
     * O(n)
     *
     =====================================*/

    public bool CanJump(int[] nums)
    {
        bool[] reachable = new bool[nums.Length];

        reachable[nums.Length - 1] = true;

        for (int i = nums.Length - 2; i >= 0; i--)
        {
            int maxStep = nums[i];

            for (int j = 1; j <= maxStep; j++)
            {
                if (i + j < nums.Length)
                {
                    if (reachable[i + j])
                    {
                        reachable[i] = true;
                        break;
                    }
                }
            }
        }

        return reachable[0];
    }
}