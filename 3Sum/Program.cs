using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -4, -1, -1, 0, 1, 2 };

            var t = ThreeSum(nums);

            Console.ReadLine();
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            Array.Sort(nums);

            var len = nums.Length;

            for (int i = 0; i < len; i++)
            {
                var font = i + 1;

                var back = len - 1;

                var tar = -nums[i];

                while (back > font)
                {
                    var sum = nums[font] + nums[back];

                    if (sum > tar)
                    {
                        back--;
                    }
                    else if (sum < tar)
                    {
                        font++;
                    }
                    else
                    {
                        List<int> list = new List<int> { nums[i], nums[font], nums[back] };
                        result.Add(list);

                        while (font < back && nums[font] == list[1])
                        {
                            font++;
                        }

                        while (font < back && nums[back] == list[2])
                        {
                            back--;
                        }
                    }
                }

                while (i + 1 < len && nums[i + 1] == nums[i])
                {
                    i++;
                }
            }

            return result;
        }
    }
}
