using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Robber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 1 };

            var t = Rob(nums);

            Console.WriteLine(t);

            Console.ReadLine();
        }

        public static int Rob(int[] nums)
        {
            int max = 0;

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(i - 2))
                {
                    var currentMax = 0;
                    foreach (var item in dic)
                    {
                        if (item.Key == i - 1)
                        {
                            continue;
                        }

                        currentMax = Math.Max(item.Value + nums[i], currentMax);
                    }

                    dic.Add(i, currentMax);
                    max = Math.Max(dic[i], dic[i - 1]);
                }
                else
                {
                    if (dic.Count > 0)
                    {
                        dic.Add(i, Math.Max(dic[0], nums[i]));
                        max = dic[i];
                    }
                    else
                    {
                        dic.Add(i, nums[i]);
                        max = nums[i];
                    }

                }

            }

            return max;
        }
    }
}
