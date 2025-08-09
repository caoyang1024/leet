using System.Collections.Generic;

namespace Problems;

public class Q242
{
    public bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> charCount = [];

        foreach (var c in s)
        {
            charCount.TryAdd(c, 0);
            charCount[c]++;
        }

        foreach (var c in t)
        {
            if (charCount.TryGetValue(c, out int count))
            {
                if (count <= 0)
                {
                    return false;
                }

                if (count == 1)
                {
                    charCount.Remove(c);
                }
                else
                {
                    charCount[c] = count - 1;
                }
            }
            else
            {
                return false;
            }
        }

        return charCount.Count == 0;
    }
}