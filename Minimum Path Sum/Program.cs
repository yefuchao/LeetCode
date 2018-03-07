using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Path_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = { { 1, 2 }, { 5, 6 }, { 1, 1 } };

            Console.WriteLine(MinPathSum(grid));

            int[,] grid2 = { { 1, 3, 1 }, { 1, 5, 1 }, { 4, 2, 1 } };

            Console.WriteLine(MinPathSum(grid2));

            int[,] grid3 = { { 1, 2, 5 }, { 3, 2, 1 } };

            Console.WriteLine(MinPathSum(grid3));

            Console.ReadLine();
        }

        public static int MinPathSum(int[,] grid)
        {

            if (grid.Length == 0)
            {
                return 0;
            }

            var row = grid.GetLength(1);
            var col = grid.GetLength(0);

            int[,] map = new int[Math.Max(row, col), Math.Max(row, col)];

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        map[0, 0] = grid[0, 0];
                    }
                    else
                    {
                        if (i > 0 && j > 0)
                        {
                            map[i, j] = Math.Min(map[i - 1, j], map[i, j - 1]) + grid[i, j];
                        }
                        else if (i > 0 && j == 0)
                        {
                            map[i, j] = map[i - 1, j] + grid[i, j];
                        }
                        else if (j > 0 && i == 0)
                        {
                            map[i, j] = map[i, j - 1] + grid[i, j];
                        }
                    }
                }
            }

            return map[col - 1, row - 1];
        }
    }
}
