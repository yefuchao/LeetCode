using System;

namespace Unique_Paths_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int m = obstacleGrid.Length;
            int n = obstacleGrid[0].Length;

            int[,] dp = new int[m + 1, n + 1];


            dp[0, 1] = 1;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //路障,此路不通
                    if (obstacleGrid[i][j] == 1)
                    {
                        dp[i + 1, j + 1] = 0;
                    }
                    else
                    {
                        dp[i + 1, j + 1] = dp[i, j + 1] + dp[i + 1, j];
                    }
                }
            }

            return dp[m, n];

        }

    }
}
