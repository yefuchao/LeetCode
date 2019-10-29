using System;
using System.Collections.Generic;

namespace Meeting_Scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static IList<int> MinAvailableDuration(int[][] slots1, int[][] slots2, int duration)
        {
            int x = 0;
            int y = 0;

            Array.Sort(slots1, new Comparison<int[]>((a, b) => a[0].CompareTo(b[0])));
            Array.Sort(slots2, new Comparison<int[]>((a, b) => a[0].CompareTo(b[0])));

            while (x < slots1.Length && y < slots2.Length)
            {
                //计算相交的时间
                int[] a = slots1[x];
                int[] b = slots2[y];
                //没有相交
                if (a[0] > b[1] || b[0] > a[1])
                {
                    if (a[1] > b[1])
                    {
                        y++;
                    }
                    else
                    {
                        x++;
                    }
                }
                else
                {
                    int t = Math.Min(a[1], b[1]) - Math.Max(a[0], b[0]);
                    if (t >= duration)
                    {
                        int start = Math.Max(a[0], b[0]);

                        return new List<int> { start, start + duration };
                    }
                    else
                    {
                        if (a[1] > b[1])
                        {
                            y++;
                        }
                        else
                        {
                            x++;
                        }
                    }
                }
            }

            return new List<int>();
        }
    }
}
