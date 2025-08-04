namespace Problems;

public class P62DP
{
    public int UniquePaths(int m, int n)
    {
        int[,] grids = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            grids[i, n - 1] = 1;
        }

        for (int i = 0; i < n; i++)
        {
            grids[m - 1, i] = 1;
        }

        for (int i = m - 2; i >= 0; i--)
        {
            for (int j = n - 2; j >= 0; j--)
            {
                grids[i, j] = grids[i + 1, j] + grids[i, j + 1];
            }
        }

        return grids[0, 0];
    }
}