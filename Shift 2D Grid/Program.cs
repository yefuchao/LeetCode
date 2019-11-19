using System;
using System.Collections.Generic;

namespace Shift_2D_Grid
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] grid = new int[4][];
            grid[0] = new int[] { 3, 8, 1, 9 };
            grid[1] = new int[] { 19, 7, 2, 5 };
            grid[2] = new int[] { 4, 6, 11, 10 };
            grid[3] = new int[] { 12, 0, 21, 13 };

            var r = ShiftGrid(grid, 1);

            Console.ReadKey();

            Console.WriteLine("Hello World!");
        }
        
        //TODO 周竞赛
        public static IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            int n = grid.Length;
            int m = grid[0].Length;

            int l = k / m;
            int p = k % m;

            IList<IList<int>> r = new List<IList<int>>();

            int startn = n == 1 ? 0 : p == 0 ? n - l : n - l - 1;
            int startm = m == 1 ? 0 : p == 0 ? p : m - p;

            for (int i = 0; i < n; i++)
            {
                IList<int> list = new List<int>();

                for (int j = 0; j < m; j++)
                {
                    list.Add(grid[startn][startm]);

                    startm += 1;

                    if (startm == m)
                    {
                        startm = 0;

                        startn = startn == n - 1 ? 0 : startn + 1;
                    }

                }

                r.Add(list);
            }
            return r;

        }
    }
}
