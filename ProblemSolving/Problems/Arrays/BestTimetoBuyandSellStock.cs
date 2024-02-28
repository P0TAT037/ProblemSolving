namespace ProblemSolving.Problems.Arrays;

// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/?envType=study-plan-v2&envId=top-interview-150

public class BestTimetoBuyandSellStock
{
    public static int Solution(int[] prices)
    {
        int low = 0;
        int profit = 0;
        for(int high = 1 ; high < prices.Length ; high++)
        {
            if (prices[low] < prices[high])
                profit = Math.Max(prices[high] - prices[low], profit);
            else
                low = high;
        }
        
        return profit;
    }

    public static int Solution2(int[] prices)
    {
        int maxProfit = 0;
        int minPrice = int.MaxValue;

        for(int i = 0 ; i < prices.Length ; i++)
        {
            if (prices[i] < minPrice)
                minPrice = prices[i];

            var profit = prices[i] - minPrice;
            if(profit > maxProfit)
                maxProfit = profit;
        }
        
        return maxProfit;
    }
}
