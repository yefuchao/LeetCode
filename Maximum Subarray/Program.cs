using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.WriteLine(MaxSubArray(nums));

            Console.ReadLine();
        }

        public static int MaxSubArray(int[] nums)
        {
            if (nums.Length < 0)
            {
                return 0;
            }
            var max = nums[0];
            var preMax = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                preMax = Math.Max(nums[i], preMax + nums[i]);
                max = Math.Max(preMax, max);
            }
            return max;
        }
    }
}
