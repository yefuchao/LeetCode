using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_Paths
{
    class Program
    {
        static void Main(string[] args)
        {

            //t = 28
            var t = UniquePathsApproveOne(1, 2);
            Console.WriteLine(t);
            Console.ReadKey();
        }

        public static int UniquePaths(int m, int n)
        {
            if (m == 1 || n == 1)
            {
                return 1;
            }

            return UniquePathsSub(m, n, new Dictionary<string, int>());

        }
        /// <summary>
        /// 改进1
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int UniquePathsApproveOne(int m, int n)
        {
            int[,] dp = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                dp[i, 0] = 1;
            }

            for (int i = 0; i < n; i++)
            {
                dp[0, i] = 1;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }

            return dp[m - 1, n - 1];
        }


        public static int UniquePathsSub(int m, int n, Dictionary<string, int> store)
        {
            if (m == 1 || n == 1)
            {
                return 1;
            }

            if (store.Keys.Contains(m + "," + n))
            {
                return store[m + "," + n];
            }

            int v = UniquePathsSub(m - 1, n, store) + UniquePathsSub(m, n - 1, store);
            store.Add(m + "," + n, v);
            return v;
        }
    }
}
