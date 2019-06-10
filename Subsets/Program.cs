

using System;
using System.Collections.Generic;

namespace Subsets
{
    class Program
    {
        static void Main(string[] args)
        {

            var t = Subsets(new int[] {1,2,3});

            Console.WriteLine(t);

            Console.ReadLine();
        }

        public static IList<IList<int>> Subsets(int[] nums)
        {
            var result = new List<IList<int>>();

            

            for (int i = 0; i < nums.Length; i++)
            {
                var ret = new List<IList<int>>();

                foreach (var item in result)
                {
                    var temp = new List<int>();
                    temp.AddRange(item);
                    temp.Add(nums[i]);

                    ret.Add(temp);
                }

                result.AddRange(ret);

                result.Add(new List<int> { nums[i] });

            }

            result.Add(new List<int>());

            return result;
        }

    }
}
