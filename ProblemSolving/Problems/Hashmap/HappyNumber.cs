namespace ProblemSolving.Problems.Hashmap;

// https://leetcode.com/problems/happy-number/description/?envType=study-plan-v2&envId=top-interview-150

internal class HappyNumber
{
    public static bool Solution(int n)
    {
        HashSet<int> visited = new HashSet<int>();
        while (true)
        {
            n = calcSum(n);
            if (n == 1)
                return true;
            else if (visited.Contains(n))
                return false;
            
            visited.Add(n);
        }
    }

    private static int calcSum(int n)
    {
        int sum = 0;
        while(n != 0)
        {
            int digit = n % 10;
            sum += digit*digit;
            n/=10;
        }
        return sum;
    }
}
