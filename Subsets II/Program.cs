using System;
using System.Collections.Generic;

namespace Subsets_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = new int[] { 1, 2, 2 };

            var t = SubsetsWithDup(nums);

            Console.ReadLine();

            //1,2,2
        }

        static IList<IList<int>> lists = new List<IList<int>>();
        static int[] map;
        static int[] g_nums;

        public static IList<IList<int>> SubsetsWithDup(int[] nums)
        {

            map = new int[nums.Length];

            Array.Sort(nums);

            g_nums = nums;

            BackTracking(0, new Stack<int>());

            lists.Add(new List<int>());

            return lists;
        }

        public static void BackTracking(int index, Stack<int> stack)
        {
            if (index == g_nums.Length)
            {
                return;
            }

            for (int i = index; i < map.Length; i++)
            {
                //单个
                //if (stack.Count == 0 && (i == 0 ? true : g_nums[i] != g_nums[i - 1]))
                //{
                //    lists.Add(new List<int> { g_nums[i] });
                //}

                //重复
                if (i > index && g_nums[i] == g_nums[i - 1] && map[i - 1] == 0)
                {
                    continue;
                }

                map[index] = 1;

                stack.Push(g_nums[i]);

                lists.Add(stack.ToArray());

                BackTracking(i + 1, stack);

                stack.Pop();
                map[index] = 0;
            }
        }
    }
}
