namespace ProblemSolving.Problems.Hashmap;

// https://leetcode.com/problems/valid-anagram/description/

public static class ValidAnagram
{
    public static bool Solution(string s, string t)
    {
        Dictionary<char, int> dict = new();
        foreach (var c in s)
        {
            if (!dict.TryAdd(c, 1))
                dict[c]++;
        }

        foreach (var c in t)
        {
            if (!dict.ContainsKey(c))
                return false;
            dict[c]--;
        }

        return dict.All(x => x.Value == 0);
    }
}