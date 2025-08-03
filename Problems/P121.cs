namespace Problems;

public class P121
{
    public int MaxProfit(int[] prices)
    {
        int max = 0;
        int i = 0, j = 1;

        while (j < prices.Length)
        {
            if (prices[j] - prices[i] > max)
            {
                max = prices[j] - prices[i];
            }
            else if (prices[j] < prices[i])
            {
                i = j;
            }

            j++;
        }

        return max;
    }
}