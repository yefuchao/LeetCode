using System;

namespace Uncrossed_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] A = new int[] { 1, 3, 7, 1, 7, 5 };
            int[] B = new int[] { 1, 9, 2, 5, 1 };

            Console.WriteLine(MaxUncrossedLines(A, B));

            Console.ReadKey();
        }

        public static int MaxUncrossedLines(int[] A, int[] B)
        {
            var la = A.Length;
            var lb = B.Length;
            var dp = new int[la + 1, lb + 1];

            for (int i = 0; i < la; i++)
            {
                for (int k = 0; k < lb; k++)
                {
                    if (A[i] == B[k])
                    {
                        dp[i + 1, k + 1] = dp[i, k] + 1;
                    }
                    else
                    {
                        dp[i + 1, k + 1] = Math.Max(dp[i + 1, k], dp[i, k + 1]);
                    }
                }
            }

            return dp[la, lb];

        }

        public static int Find(int[] A, int[] B, int a, int b)
        {
            int max = 0;

            var la = A.Length;
            var lb = B.Length;

            if (a >= la || b >= lb)
            {
                return 0;
            }

            for (int i = a; i < la; i++)
            {
                for (int j = b; j < lb; j++)
                {
                    if (A[i] == B[j])
                    {
                        return Math.Max(Find(A, B, i + 1, j + 1) + 1, Find(A, B, a + 1, b));
                    }
                }
            }

            return max;
        }
    }
}
