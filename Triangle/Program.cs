using System;
using System.Collections.Generic;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IList<IList<int>> list = new List<IList<int>>();

            IList<int> list1 = new List<int>
            {
                1
            };

            list.Add(list1);

            IList<int> list2 = new List<int>
            {
                2,3
            };

            list.Add(list2);

            IList<int> list3 = new List<int>
            {
                4,5,6
            };

            list.Add(list3);

            Console.WriteLine(MinimumTotal(list));

            Console.ReadKey();

        }

        public static int MinimumTotal(IList<IList<int>> triangle)
        {
            if (triangle.Count == 0)
            {
                return 0;
            }

            int[] sums = new int[triangle.Count];

            sums[0] = triangle[0][0];

            int pre = 0;
            int temp = 0;

            for (int i = 1; i < triangle.Count; i++)
            {
                for (int p = 0; p < triangle[i].Count; p++)
                {
                    if (p == 0)
                    {
                        pre = sums[p];
                        sums[p] += triangle[i][p];
                    }
                    else if (p == triangle[i].Count - 1)
                    {
                        sums[p] = pre + triangle[i][p];
                    }
                    else
                    {
                        temp = sums[p];
                        sums[p] = Math.Min(pre, sums[p]) + triangle[i][p];
                        pre = temp;
                    }
                }
            }

            int min = sums[0];
            for (int i = 1; i < sums.Length; i++)
            {
                min = Math.Min(min, sums[i]);
            }

            return min;
        }
    }
}
