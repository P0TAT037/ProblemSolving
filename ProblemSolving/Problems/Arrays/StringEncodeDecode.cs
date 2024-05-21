using System.Text;

namespace ProblemSolving.Problems.Arrays;

// https://neetcode.io/problems/string-encode-and-decode

public static class StringEncodeDecode
{
    public static string Encode(IList<string> strs)
    {
        StringBuilder encoded = new();
        foreach (var str in strs)
        {
            encoded.Append(str.Length.ToString() + "#");
            encoded.Append(str);
        }

        return encoded.ToString();
    }

    public static List<string> Decode(string s)
    {
        List<string> list = new();
        
        var lengthString = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != '#')
            {
                lengthString += s[i];
                continue;
            }

            i++;
            list.Add(s.Substring(i,int.Parse(lengthString)));
            i += int.Parse(lengthString)-1;
            lengthString = "";
        }

        return list;
    }
}