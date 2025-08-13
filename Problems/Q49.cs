using System;
using System.Collections.Generic;

namespace Problems;

public class Q49
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> dict = new();

        foreach (string s in strs)
        {
            var arr = s.ToCharArray();
            Array.Sort(arr);
            string newStr = new string(arr);

            if (dict.TryGetValue(newStr, out var list))
            {
                list.Add(s);
            }
            else
            {
                dict[newStr] = new List<string>() { s };
            }
        }

        List<IList<string>> result = new List<IList<string>>();

        foreach (var dictValue in dict.Values)
        {
            result.Add(dictValue);
        }

        return result;
    }
}