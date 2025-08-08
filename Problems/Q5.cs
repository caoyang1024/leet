using System;

namespace Problems;

public class Q5
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return "";

        var span = s.AsSpan();

        var max = 1;

        int h = 0, l = 0;

        for (var i = 1; i < span.Length; i++)
        {
            var (lo1, hi1) = FindLongest(span, i, i);

            if (hi1 - lo1 + 1 > max)
            {
                max = hi1 - lo1 + 1;
                h = hi1;
                l = lo1;
            }

            if (span[i - 1] == span[i])
            {
                var (lo2, hi2) = FindLongest(span, i - 1, i);

                if (hi2 - lo2 + 1 > max)
                {
                    max = hi2 - lo2 + 1;
                    h = hi2;
                    l = lo2;
                }
            }
        }

        return span.Slice(l, h - l + 1).ToString();
    }

    private (int low, int high) FindLongest(ReadOnlySpan<char> span, int l, int h)
    {
        int low = l, high = h;

        while (l >= 0 && h < span.Length)
        {
            if (span[l] == span[h])
            {
                low = l;
                high = h;

                l--;
                h++;
            }
            else
            {
                break;
            }
        }

        return (low, high);
    }
}