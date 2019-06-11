using System;
using System.Collections.Generic;

namespace SubsetsII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var t = SubsetsWithDup(new int[] { 1, 1, 2, 2 });

            Console.WriteLine(t);

            Console.ReadLine();
        }

        public static IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            var result = new List<IList<int>>();

            Array.Sort(nums);

            var pre = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                var ret = new List<IList<int>>();

                if (i > 0 && nums[i] == nums[i - 1])
                {
                    foreach (var item in pre)
                    {
                        var temp = new List<int>();
                        temp.AddRange(item);
                        temp.Add(nums[i]);

                        ret.Add(temp);
                    }
                }
                else
                {
                    foreach (var item in result)
                    {
                        var temp = new List<int>();
                        temp.AddRange(item);
                        temp.Add(nums[i]);

                        ret.Add(temp);

                    }

                    var single = new List<int> { nums[i] };
                    ret.Add(single);
                }

                result.AddRange(ret);
                pre = ret;
            }

            result.Add(new List<int>());

            return result;
        }
    }
}
