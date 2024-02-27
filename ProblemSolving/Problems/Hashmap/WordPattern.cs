using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Hashmap;

public class WordPattern
{
    public static bool Solution(string pattern, string s)
    {
        var str = s.Split(' ');

        if (pattern.Length != str.Length)
            return false;

        Dictionary<char, string> map = new();

        for (int i = 0; i < str.Length; i++)
        {
            if (map.ContainsKey(pattern[i]))
            {
                if (map[pattern[i]] != str[i])
                    return false;
                else
                    continue;
            }

            if (map.ContainsValue(str[i]))
                return false;

            map.Add(pattern[i], str[i]);

        }
        return true;
    }

    public static bool Solution2(string pattern, string s)
    {
        var dict1 = new Dictionary<char, string>();
        var dict2 = new Dictionary<string, char>();
        var str = s.Split(' ');

        if (pattern.Length != str.Count()) return false;

        for (int i = 0; i < str.Count(); i++)
        {
            dict1.TryAdd(pattern[i], str[i]);
            dict2.TryAdd(str[i], pattern[i]);

            if (dict1[pattern[i]] != str[i])
                return false;

            if (dict2[str[i]] != pattern[i])
                return false;
        }

        return true;
    }
}
