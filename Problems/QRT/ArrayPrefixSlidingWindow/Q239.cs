using System;
using System.Collections.Generic;

namespace Problems.QRT.ArrayPrefixSlidingWindow;

/*=====================================
 *
 * 239: Sliding Window Maximum
 * Stars: ⭐⭐⭐⭐⭐
 * Sliding Window
 * Monotonic Queue / Deque
 * O(n)
 *
 =====================================*/
public class Q239
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        LinkedList<int> deque = [];

        int[] result = new int[nums.Length - k + 1];

        for (int i = 0; i < nums.Length; i++)
        {
            while (deque.Count > 0 && deque.Last != null && nums[i] > nums[deque.Last.Value])
            {
                deque.RemoveLast();
            }

            deque.AddLast(i);

            if (i >= k - 1)
            {
                if (deque.First == null) throw new ArgumentNullException();

                result[i + 1 - k] = nums[deque.First.Value];

                if (i - deque.First.Value + 1 >= k)
                {
                    deque.RemoveFirst();
                }
            }
        }

        return result;
    }
}