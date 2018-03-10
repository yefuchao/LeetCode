using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Robber_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 9, 3, 1 };

            Console.WriteLine(Rob(nums));

            Console.ReadLine();
        }

        public static int Rob(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            return Math.Max(LineRob(nums, 0, nums.Length - 2), LineRob(nums, 1, nums.Length - 1));
        }

        public static int LineRob(int[] nums, int start, int end)
        {
            var include = 0;
            var exclude = 0;

            for (int j = start; j <= end; j++)
            {
                var i = include;
                var e = exclude;

                include = nums[j] + e;
                exclude = Math.Max(e, i);

            }

            return Math.Max(include, exclude);
        }
    }
}
