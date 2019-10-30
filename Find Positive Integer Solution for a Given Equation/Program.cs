using System;
using System.Collections.Generic;

namespace Find_Positive_Integer_Solution_for_a_Given_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static IList<IList<int>> FindSolution(CustomFunction customfunction, int z)
        {
            List<IList<int>> res = new List<IList<int>>();

            int x = 1;
            int y = 1;

            while (true)
            {
                int v = customfunction.f(x, y);

                if(v > z)
                {
                    break;
                }

                x++;
            }

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                   int v =  customfunction.f(i,j);
                    if (v == z)
                    {
                        List<int> l = new List<int> { i, j };
                        res.Add(l);
                    }
                }
            }

            return res;
        }
    }
}
