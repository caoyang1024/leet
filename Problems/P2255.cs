using System;

namespace Problems;

/// <summary>
/// 2255. Count Prefixes of a Given String
/// </summary>
public class P2255
{
    public int CountPrefixes(string[] words, string s)
    {
        int count = 0;

        char[] charArr = s.ToCharArray();

        foreach (var word in words)
        {
            var wordArr = word.ToCharArray();

            if (wordArr.Length > charArr.Length)
            {
                continue;
            }

            bool isPrefix = true;

            for (int i = 0; i < Math.Min(charArr.Length, wordArr.Length); i++)
            {
                if (charArr[i] != wordArr[i])
                {
                    isPrefix = false;
                    break;
                }
            }

            if (isPrefix)
            {
                count++;
            }
        }

        return count;
    }
}