using System;

namespace Matrix_Block_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[][] mat = new int[3][];

            int x = 1;
            for (int i = 0; i < mat.Length; i++)
            {
                mat[i] = new int[] { x++, x++, x++ };
            }

            var r = MatrixBlockSum(mat, 1);

            Console.ReadKey();
        }

        public static int[][] MatrixBlockSum(int[][] mat, int K)
        {

            var m = mat.Length;
            var n = mat[0].Length;

            var sum = new int[m + 1][];

            sum[0] = new int[n+1];
            for (int i = 1; i <= m; i++)
            {
                sum[i] = new int[n + 1];
                for (int j = 1; j <= n; j++)
                {
                    sum[i][j] = mat[i-1][j-1] + sum[i - 1][j] + sum[i][j - 1] - sum[i - 1][j - 1];
                }
            }

            var answer = new int[m][];

            for (int i = 0; i < m; i++)
            {
                answer[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    int r1 = Math.Max(0, i - K);
                    int c1 = Math.Max(0, j - K);
                    int r2 = Math.Min(m - 1, i + K);
                    int c2 = Math.Min(n - 1, j + K);

                    r1++;
                    c1++;
                    r2++;
                    c2++;

                    answer[i][j] = sum[r2][c2] - sum[r2][c1 - 1] - sum[r1 - 1][c2] + sum[r1 - 1][c1 - 1];
                }
            }

            return answer;
        }
    }
}
