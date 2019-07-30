using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            var list =   Permute(new int[] { 1, 2, 3 });

            Console.WriteLine(list.Count());
            Console.ReadLine();
        }

        public static IList<IList<int>> Permute(int[] nums)
        {
            List<IList<int>> list = new List<IList<int>>();

            if (nums.Length == 0)
            {
                return list;
            }

            list.Add(new List<int> { nums[0] });
            
            for (int i = 1; i < nums.Length; i++)
            {
                var temp = new List<IList<int>>();
                temp.AddRange(list);
                list.Clear();

                foreach (var item in temp)
                {
                    for (int pos = 0; pos <= item.Count; pos++)
                    {
                        var cur = new List<int>();
                        cur.AddRange(item);
                        cur.Insert(pos, nums[i]);
                        list.Add(cur);
                    }
                }
            }

            return list;
        }

    }
}
