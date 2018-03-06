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

            Console.ReadLine();
        }

        public static int MinPathSum(int[,] grid)
        {
            //TODO

            if (grid.Length == 0)
            {
                return 0;
            }

            var row = grid.GetLength(1); // 行数

            var col = grid.GetLength(0); //列数

            int[,] map = new int[col, col];

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
                        else
                        {
                            Console.WriteLine(i);
                            Console.WriteLine(j);
                            Console.WriteLine("------");
                        }
                    }
                }
            }

            return map[row - 1, col - 1];
        }
    }
}
