using System;
using System.Collections.Generic;

namespace Problems.Backtrack;

public class Q131
{
    public IList<IList<string>> Partition(string s)
    {
        var span = s.AsSpan();

        List<IList<string>> list = [];

        Partition(span, 0, new List<string>(), list);

        return list;
    }

    private void Partition(ReadOnlySpan<char> span, int start, IList<string> list, IList<IList<string>> res)
    {
        if (start >= span.Length)
        {
            res.Add(new List<string>(list));
            return;
        }

        for (var i = start; i < span.Length; i++)
        {
            if (IsPalindrome(span, start, i))
            {
                list.Add(span.Slice(start, i - start + 1).ToString());

                Partition(span, i + 1, list, res);

                list.RemoveAt(list.Count - 1);
            }
        }
    }

    private bool IsPalindrome(ReadOnlySpan<char> span, int lo, int hi)
    {
        while (lo < hi)
        {
            if (span[lo] != span[hi])
            {
                return false;
            }

            lo++;
            hi--;
        }

        return true;
    }
}