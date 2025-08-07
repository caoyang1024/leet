using System;
using System.Collections.Generic;

namespace Problems;

public class Q9
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        LinkedList<int> deque = [];

        while (x != 0)
        {
            var remainder = x % 10;

            x /= 10;

            deque.AddLast(remainder);
        }

        while (deque.Count > 1)
        {
            if (deque.First == null || deque.Last == null)
            {
                throw new ArgumentNullException();
            }

            var head = deque.First.Value;
            var tail = deque.Last.Value;

            if (head != tail)
            {
                return false;
            }

            deque.RemoveFirst();
            deque.RemoveLast();
        }

        return true;
    }
}