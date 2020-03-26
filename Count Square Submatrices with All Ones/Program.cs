using System;

namespace Count_Square_Submatrices_with_All_Ones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 0, 1, 1, 1 };
            matrix[1] = new int[] { 1, 1, 1, 1 };
            matrix[2] = new int[] { 0, 1, 1, 1 };

            var ans = CountSquares(matrix);

            Console.WriteLine(ans);

            Console.ReadLine();

        }

        static int CountSquares(int[][] matrix)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;

            int[,] mat = new int[m + 1, n + 1];

            var sum = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (matrix[i - 1][j - 1] == 0)
                    {
                        mat[i, j] = 0;

                        continue;
                    }

                    if (mat[i - 1, j - 1] == mat[i - 1, j] && mat[i - 1, j - 1] == mat[i, j - 1])
                    {
                        mat[i, j] = mat[i - 1, j] + 1;
                    }
                    else
                    {
                        mat[i, j] = Math.Min(mat[i - 1, j - 1], Math.Min(mat[i - 1, j], mat[i, j - 1])) + 1;
                    }

                    sum += mat[i, j];
                }
            }


            return sum;

        }

    }
}
