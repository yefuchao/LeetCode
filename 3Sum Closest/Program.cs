using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Sum_Closest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 0 };

            Console.WriteLine(ThreeSumCloest(nums, 100));
            Console.ReadLine();
        }

        public static int ThreeSumCloest(int[] nums, int target)
        {
            Array.Sort(nums);

            var cloest = Math.Abs(nums[nums.Length - 1] + nums[nums.Length - 2] + nums[nums.Length - 3] - target);

            var a = 0;
            var b = 0;
            var c = 0;

            var len = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                var font = i + 1;
                var back = len - 1;

                while (back > font)
                {
                    var sum = nums[i] + nums[font] + nums[back];

                    var distance = Math.Abs(sum - target);

                    if (distance <= cloest)
                    {
                        a = nums[i];
                        b = nums[font];
                        c = nums[back];
                        cloest = distance;
                    }

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
                        return target;
                    }
                }
            }

            return a + b + c;
        }

        public static int ThreeSumCloese(int[] nums,int target)
        {

            Array.Sort(nums);
            long result = Int32.MaxValue;

            for (int i = 0; i + 2 < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int j = i + 1;
                int k = nums.Length - 1;

                while (j < k)
                {
                    result = Math.Abs(result - target) > Math.Abs(nums[i] + nums[j] + nums[k] - target) ? nums[i] + nums[j] + nums[k] : result;

                    if (nums[i] + nums[j] + nums[k] > target)
                    {
                        k--;

                        if (j < k && nums[k] == nums[k + 1])
                        {
                            k--;
                        }
                    }
                    else if (nums[i] + nums[j] + nums[k] < target)
                    {
                        j++;

                        if (j < k && nums[j] == nums[j - 1])
                        {
                            j++;
                        }
                    }
                    else
                    {
                        return (int)result;
                    }
                }
            }

            return (int)result;


        }
    }
}
