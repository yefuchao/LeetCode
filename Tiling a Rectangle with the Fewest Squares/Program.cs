using System;

namespace Tiling_a_Rectangle_with_the_Fewest_Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //correct 6
            var min = TilingRectangle(11, 13);

            Console.WriteLine(min);
            Console.ReadKey();

        }

        public static int TilingRectangle(int n, int m)
        {
            if (n == m)
            {
                return 1;
            }

            int x = Math.Min(n, m);

            int min = m * n;

            for (int i = 7; i <= x; i++)
            {
                min = Math.Min(min, 1 + TilingRectangle(i, n - i) + TilingRectangle(n, m - i));
            }

            return min;

        }

        //public static int Find(int s, int n)
        //{
        //    int ans = s;

        //    for (int i = 1; i < n; i++)
        //    {
        //        ans = Math.Min(ans,1 + )
        //    }
        //}
    }
}
