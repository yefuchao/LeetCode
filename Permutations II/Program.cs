using System;
using System.Collections.Generic;

namespace Permutations_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = new int[] { 1, 1, 2 };

            var r = PermuteUnique(nums);

            Console.ReadKey();
        }

        static IList<IList<int>> lists;
        static int[] g_nums;
        static int[] store;

        public static IList<IList<int>> PermuteUnique(int[] nums)
        {
            lists = new List<IList<int>>();

            Array.Sort(nums);
            g_nums = nums;
            store = new int[nums.Length];

            BackTrack(new List<int>());


            return lists;
        }

        public static void BackTrack(List<int> list)
        {
            if (list.Count == g_nums.Length)
            {
                var temp = new List<int>(list);
                lists.Add(temp);
                return;
            }

            for (int i = 0; i < g_nums.Length; i++)
            {
                if (store[i] == 1)
                {
                    continue;
                }

                if (i > 0 && g_nums[i - 1] == g_nums[i] && store[i - 1] == 0)
                {
                    continue;
                }

                store[i] = 1;
                list.Add(g_nums[i]);
                BackTrack(list);
                list.RemoveAt(list.Count - 1);
                store[i] = 0;
            }
        }
    }
}
