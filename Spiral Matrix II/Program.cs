using System;

namespace Spiral_Matrix_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var t = GenerateMatrix(3);
            Console.ReadKey();

        }


        public static int[][] GenerateMatrix(int n)
        {
            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[n];
            }
            //int[,] arr = new int[n, n];
            int round = 0;
            int step = 1;
            while (step <= n * n)
            {

                for (int i = round; i < n - round; i++)
                {
                    arr[round][i] = step;
                    step++;
                }

                for (int i = round + 1; i < n - round; i++)
                {
                    arr[i][n - round - 1] = step;
                    step++;
                }

                for (int i = n - round - 2; i > round; i--)
                {
                    arr[n - round - 1][i] = step;
                    step++;
                }

                for (int i = n - round - 1; i > round; i--)
                {
                    arr[i][round] = step;
                    step++;
                }

                round++;

            }

            return arr;
        }
    }
}
