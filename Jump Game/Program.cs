using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = new int[] { 2, 3, 1, 1, 4 };
            int[] nums = { 3, 2, 1, 0, 4 };

            var lasIndex = nums.Length - 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i + nums[i] >= lasIndex)
                {
                    lasIndex = i;
                }
            }

            Console.WriteLine(lasIndex == 0);

            Console.ReadLine();

        }

        /// <summary>
        /// fastest
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        private static bool CanJump(int[] nums)
        {
            int reachable = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                if (i > reachable) return false;
                reachable = Math.Max(reachable, i + nums[i]);
            }
            return true;
        }
    }
}
