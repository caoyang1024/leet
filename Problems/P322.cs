using System;

namespace Problems;

public class P322
{
    public int CoinChange(int[] coins, int amount)
    {
        int[] f = new int[amount + 1];

        f[0] = 0;

        for (int i = 1; i <= amount; i++)
        {
            f[i] = int.MaxValue;

            foreach (var coin in coins)
            {
                if (i - coin >= 0 && f[i - coin] != int.MaxValue)
                {
                    f[i] = Math.Min(f[i], f[i - coin] + 1);
                }
            }
        }

        if (f[amount] == int.MaxValue)
        {
            return -1;
        }

        return f[amount];
    }
}