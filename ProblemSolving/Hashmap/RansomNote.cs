using System.Collections;

namespace ProblemSolving.Hashmap;

// https://leetcode.com/problems/ransom-note/description/?envType=study-plan-v2&envId=top-interview-150

public class RansomNote
{
    public static bool Solutoin(string ransomNote, string magazine)
    {
        Dictionary<char, int> ransomFreq = new();
        Dictionary<char, int> magazineFreq = new();
        
        foreach(char c in magazine)
        {
            if (magazineFreq.ContainsKey(c)) 
                magazineFreq[c]++;
            else
                magazineFreq.Add(c, 1);
        }
        
        foreach(char c in ransomNote)
        {
            if (ransomFreq.ContainsKey(c)) 
                ransomFreq[c]++;
            else
                ransomFreq.Add(c, 1);
        }

        foreach (char c in ransomFreq.Keys)
        {
            try
            {
                if (ransomFreq[c] > magazineFreq[c])
                    return false;
            }
            catch
            {
                return  false; 
            }
        }
        
        return true;
    }

    public static bool Solution2(string ransomNote, string magazine)
    {
        var list = new List<char>(ransomNote);
        var counter = 0;
        foreach (var element in magazine)
        {
            if (list.Remove(element))
            {
                counter++;
            }
        }
        return ransomNote.Length == counter;
    }
}
