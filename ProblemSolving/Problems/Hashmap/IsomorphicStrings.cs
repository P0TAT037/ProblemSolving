namespace ProblemSolving.Problems.Hashmap;

// https://leetcode.com/problems/isomorphic-strings/description/?envType=study-plan-v2&envId=top-interview-150

public class IsomorphicStrings
{
    public static bool Solution(string s, string t)
    {
        if (s.Length != t.Length) return false;

        Dictionary<char, char> map = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]))
            {
                if (map[s[i]] != t[i])
                    return false;

            }
            else
            {
                if (map.ContainsValue(t[i]))
                    return false;

                map[s[i]] = t[i];
            }
        }
        return true;
    }
}
