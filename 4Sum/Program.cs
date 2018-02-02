using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -5, 5, 4, -3, 0, 0, 4, -2 }; // 0

            // nums = new int[] { -2, -1, 0, 0, 1, 2 }; //

            //nums = new int[] { 5, 5, 3, 5, 1, -5, 1, -2 }; //4

            nums = new int[] { 0, 0, 0, 0 };

            var t = FourSum(nums, 0);

            Console.ReadLine();
        }

        public static IList<IList<int>> FourSum(int[] nums, int target)
        {

            //todo

            IList<IList<int>> result = new List<IList<int>>();

            Array.Sort(nums);

            var len = nums.Length;

            for (int i = 0; i < len - 3; i++)
            {
                for (int j = len - 1; j >= 0; j--)
                {
                    if (j == i)
                    {
                        continue;
                    }

                    var font = i + 1;

                    var back = j - 1;

                    while (back > font)
                    {
                        var sum = nums[i] + nums[j] + nums[font] + nums[back];

                        if (sum < target)
                        {
                            font++;
                        }
                        else if (sum > target)
                        {
                            back--;
                        }
                        else
                        {
                            List<int> list = new List<int> { nums[i], nums[j], nums[font], nums[back] };

                            result.Add(list);

                            font++;
                            back--;

                            while (nums[font] == list[2] && font < back)
                            {
                                font++;
                            }

                            while (nums[back] == list[3] && back > font)
                            {
                                back--;
                            }
                        }

                    }

                    while (j > 2 && nums[j] == nums[j - 1] && j > i)
                    {
                        j--;
                    }
                }

                while (nums[i] == nums[i++] && i < len - 3)
                {
                    i++;
                }
            }

            return result;
        }
    }
}
