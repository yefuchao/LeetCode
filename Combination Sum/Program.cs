using System;
using System.Collections.Generic;
using System.Linq;

namespace Combination_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] candidates = new int[] { 2, 3, 6, 7 };

            CombinationSum(candidates, 7);

            Console.ReadLine();
        }

        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);

            IList<IList<int>> lists = new List<IList<int>>();

            BackTrack(candidates, target, lists, new List<int>(), 0);

            return lists;
        }

        
        public static void BackTrack(int[] candidates, int target, IList<IList<int>> lists, IList<int> list, int first)
        {
            if (list.Sum() == target)
            {
                var temp = new List<int>();
                temp.AddRange(list);

                lists.Add(temp);

                return;
            }

            if (list.Sum() > target)
            {
                return;
            }

            for (int i = first; i < candidates.Length; i++)
            {
                list.Add(candidates[i]);
                BackTrack(candidates, target, lists, list, i);
                list.RemoveAt(list.Count() - 1);
            }
        }
    }
}
