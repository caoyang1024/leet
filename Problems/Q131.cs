using System;
using System.Collections.Generic;

namespace Problems;

public class Q131
{
    /*
     * Given a string s, partition s such that every substring of the partition is a palindrome. Return all possible palindrome partitioning of s.
     *
     *Example 1:

       Input: s = "aab"
       Output: [["a","a","b"],["aa","b"]]
       Example 2:

       Input: s = "a"
       Output: [["a"]]
     */

    private bool IsPalindrome(ReadOnlySpan<char> span, int i, int j)
    {
        while (i < j)
        {
            if (span[i] != span[j])
            {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }

    public IList<IList<string>> Partition(string s)
    {
        var span = s.AsSpan();

        List<IList<string>> list = [];

        for (int i = 0; i < span.Length; i++)
        {
            for (int j = 0; j < span.Length; j++)
            {
                throw new NotImplementedException();
            }
        }

        return list;
    }
}