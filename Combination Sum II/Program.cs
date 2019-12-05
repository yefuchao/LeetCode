using System;
using System.Collections.Generic;

namespace Combination_Sum_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] candidates = new int[] { 1, 1, 2, 5, 6, 7, 10 };

            // 2,5,2,1,2  => 5  多个重复数字的情况

            CombinationSum2(candidates, 8);
        }

        static IList<IList<int>> lists;

        static int[] g_candidates;

        public static IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);

            lists = new List<IList<int>>();
            g_candidates = candidates;

            BackTrack(0, target, new Stack<int>());

            return lists;
        }

        public static void BackTrack(int first, int residue, Stack<int> stack)
        {
            if (residue == 0)
            {
                lists.Add(stack.ToArray());
            }

            for (int i = first; i < g_candidates.Length && residue > 0; i++)
            {
                //【关键】判断当前是不是第一个用和first比较
                if (i != first && g_candidates[i] == g_candidates[i - 1])
                {
                    continue;
                }
                stack.Push(g_candidates[i]);
                BackTrack(i + 1, residue - g_candidates[i], stack);
                stack.Pop();
            }
        }
    }
}
