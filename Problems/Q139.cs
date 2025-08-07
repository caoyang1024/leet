using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems;

public class Q139
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        var hs = wordDict.ToHashSet();

        var span = s.AsSpan();

        return WordBreak(span, 0, hs);
    }

    private bool WordBreak(ReadOnlySpan<char> str, int start, HashSet<string> hs)
    {
        for (int i = start; i < str.Length; i++)
        {
            bool found = false;

            for (int j = i + 1; j <= str.Length; j++)
            {
                string word = str.Slice(i, j - i).ToString();

                if (hs.Contains(word) && j == str.Length)
                {
                    return true;
                }

                if (hs.Contains(word))
                {
                    found = true;

                    if (WordBreak(str, j, hs))
                    {
                        return true;
                    }
                }
                else if (found)
                {
                    break;
                }

                if (j == str.Length)
                {
                    return false;
                }
            }
        }

        return false;
    }
}