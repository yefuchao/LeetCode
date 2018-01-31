using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_Game_II
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// 思路：取每次能跳跃的最大值
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, 1, 1, 4 };

            Console.WriteLine(Jumps(nums));
            Console.ReadLine();
        }

        public static int FastJump(int[] nums)
        {
            if (nums == null || nums.Length < 2) { return 0; }
            int length = nums.Length;
            int curMax = nums[0];
            int nextMax = curMax;
            int jumps = 1;
            for (int idx = 1; idx < length - 1; idx++)
            {
                if (idx + nums[idx] > nextMax)
                {
                    nextMax = idx + nums[idx];
                }
                if (idx == curMax)
                {
                    jumps++;
                    curMax = nextMax;
                }
            }
            return jumps;
        }


        public static int Jumps(int[] nums)
        {
            int jump = 0;
            int curEnd = 0;
            int curFast = 0;

            for (int i = 0; i < nums.Count() - 1; i++)
            {
                curFast = Math.Max(curFast, i + nums[i]);

                if (i == curEnd)
                {
                    jump++;
                    curEnd = curFast;
                }
            }

            return jump;
        }

        public static int Jump(int[] nums)
        {
            var count = 0;

            var value = nums[0];

            var pos = 0;

            while (value < nums.Count())
            {
                pos = GetMax(nums, pos);
                value += nums[pos];
                count++;
            }

            return count;
        }

        public static int GetMax(int[] nums, int k)
        {
            int max = 0;

            for (int i = k + 1; i < k + nums[k] - 1; i++)
            {
                if (nums[i] + i <= nums[i + 1] + i + 1)
                {
                    max = i + 1;
                }
                else
                {
                    max = i;
                }
            }

            return max;
        }
    }
}
