namespace Problems;

public class P122
{
    public int MaxProfit(int[] prices)
    {
        int totalProfit = 0;

        int i = 0, j = 1;

        int currentMax = 0;

        while (j < prices.Length)
        {
            // for every price drop, we move our buy position
            if (prices[j] < prices[j - 1])
            {
                i = j;

                totalProfit += currentMax;
                currentMax = 0;
            }
            else if (prices[j] - prices[i] > currentMax)
            {
                currentMax = prices[j] - prices[i];
            }

            j++;
        }

        return totalProfit + currentMax;
    }
}