using System;

namespace Max_Increase_to_Keep_City_Skyline
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            int incrase = 0;
            var x = grid.Length;

            var y = 0;
            if (x > 0)
            {
                y = grid[0].Length;
            }

            //行
            var arrx = new int[x];
            //列
            var arry = new int[y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (grid[i][j] > arrx[i])
                    {
                        arrx[i] = grid[i][j];
                    }
                    if (grid[i][j] > arry[j])
                    {
                        arry[j] = grid[i][j];
                    }
                }
            }

            //行
            for (int i = 0; i < x; i++)
            {
                //列
                for (int j = 0; j < y; j++)
                {
                    incrase += Math.Min(arrx[i], arry[j]) - grid[i][j];
                }
            }

            return incrase;
        }


    }
}
