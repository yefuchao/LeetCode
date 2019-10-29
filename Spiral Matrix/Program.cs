using System;
using System.Collections.Generic;
using System.Linq;

namespace Spiral_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[][] matrix = new int[4][];
            matrix[0] = new int[] { 1, 2, 3, 4 };
            matrix[1] = new int[] { 5, 6, 7, 8 };
            matrix[2] = new int[] { 9, 10, 11, 12 };
            matrix[3] = new int[] { 13, 14, 15, 16 };

            var list = SpiralOrder(matrix);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }

        public static IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> list = new List<int>();

            if (matrix.Length == 0)
            {
                return list;
            }

            if (matrix.Length == 1)
            {
                return matrix[0].ToList();
            }

            int lineTop = 0;
            int lineBottom = matrix.Length - 1;
            int colLeft = 0;
            int colRight = matrix[0].Length - 1;
            int curX = 0;
            int curY = 0;

            int arrow = 0; // 0,1,2,3  right,down,left,up

            bool c = true;

            while (c)
            {
                switch (arrow)
                {
                    case 0:
                        while (curX <= colRight)
                        {
                            list.Add(matrix[curY][curX]);
                            curX++;
                        }
                        lineTop++;
                        arrow = 1;
                        curY++;
                        curX--;

                        if (curY > lineBottom)
                        {
                            c = false;
                        }

                        break;
                    case 1:
                        while (curY <= lineBottom)
                        {
                            list.Add(matrix[curY][curX]);
                            curY++;
                        }
                        colRight--;
                        arrow = 2;
                        curX--;
                        curY--;
                        if (curX < colLeft)
                        {
                            c = false;
                        }
                        break;
                    case 2:
                        while (curX >= colLeft)
                        {
                            list.Add(matrix[curY][curX]);
                            curX--;
                        }
                        lineBottom--;
                        curY--;
                        curX++;
                        arrow = 3;
                        if (curY < lineTop)
                        {
                            c = false;
                        }
                        break;
                    case 3:
                        while (curY >= lineTop)
                        {
                            list.Add(matrix[curY][curX]);
                            curY--;
                        }
                        colLeft++;
                        arrow = 0;
                        curX++;
                        curY++;
                        if (curX > colRight)
                        {
                            c = false;
                        }
                        break;
                }
            }

            return list;

        }
    }
}
