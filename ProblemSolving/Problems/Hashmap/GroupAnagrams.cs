using System.Text;

namespace ProblemSolving.Problems.Hashmap;

// https://leetcode.com/problems/group-anagrams/

public static class GroupAnagrams
{
    public static IList<IList<string>> Solution(string[] strs)
    {
        var maps = new Dictionary<string, IList<string>>();
        StringBuilder keyBuilder = new();
        foreach (var t in strs)
        {
            var arr = t.ToCharArray();
            Array.Sort(arr);
            string key = new string(arr);

            if(!maps.TryAdd(key, [t]))
                maps[key].Add(t);
            keyBuilder.Clear();
        }

        var result = maps.Values.ToList();
        return result;
    }
}