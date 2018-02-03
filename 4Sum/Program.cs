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

            nums = new int[] { 5, 5, 3, 5, 1, -5, 1, -2 }; //4

            //nums = new int[] { 0, 0, 0, 0 };

            nums = new int[] { -3, -2, -1, 0, 0, 1, 2, 3 }; //0

            var t = FourSum(nums, 0);

            Console.ReadLine();
        }

        public static IList<IList<int>> FourSum(int[] nums, int target)
        {

            IList<IList<int>> result = new List<IList<int>>();

            Array.Sort(nums);

            var len = nums.Length;

            for (int i = 0; i < len - 3; i++)
            {
                for (int j = i + 1; j < len - 2; j++)
                {
                    var font = j + 1;
                    var back = len - 1;

                    while (font < back)
                    {
                        var sum = nums[i] + nums[j] + nums[font] + nums[back];

                        if (target > sum)
                        {
                            font++;
                        }
                        else if (target < sum)
                        {
                            back--;
                        }
                        else
                        {
                            var list = new List<int> { nums[i], nums[j], nums[font], nums[back] };

                            result.Add(list);

                            font++;
                            back--;

                            while (font < back && nums[font] == list[2])
                            {
                                font++;
                            }

                            while (back > font && nums[back] == list[3])
                            {
                                back--;
                            }
                        }
                    }



                    while (j < len - 3 && nums[j] == nums[j + 1])
                    {
                        j++;
                    }
                }

                while (i < len - 4 && nums[i] == nums[i + 1])
                {
                    i++;
                }
            }


            return result;
        }
    }
}
