using System;
using System.Collections.Generic;
using System.Linq;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Combine(4, 3);
        }

        static IList<IList<int>> lists;
        static int gn;
        static int gk;

        public static IList<IList<int>> Combine(int n, int k)
        {
            lists = new List<IList<int>>();

            gn = n;
            gk = k;

            BackTrack(1, new List<int>());


            return lists;
        }

        public static void BackTrack(int first, List<int> list)
        {
            //list.Sum();
            if (list.Count == gk)
            {
                var temp = new List<int>();
                temp.AddRange(list);
                lists.Add(temp);
                return;
            }

            for (int i = first; i < gn + 1; i++)
            {
                list.Add(i);

                BackTrack(i + 1, list);

                list.Remove(i);

                list.RemoveAt(list.Count() - 1);
            }
        }
    }
}
