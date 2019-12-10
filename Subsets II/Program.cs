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

        static readonly IList<IList<int>> lists = new List<IList<int>>();
        static int[] g_nums;

        public static IList<IList<int>> SubsetsWithDup(int[] nums)
        {
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

            for (int i = index; i < g_nums.Length; i++)
            {
                //重复
                if (i > index && g_nums[i] == g_nums[i - 1])
                {
                    continue;
                }
                stack.Push(g_nums[i]);

                lists.Add(stack.ToArray());

                BackTracking(i + 1, stack);

                stack.Pop();
            }
        }
    }
}
