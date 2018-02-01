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
            //todo
            Array.Sort(nums);
            var cloest = Math.Abs(nums[nums.Length - 1] + nums[nums.Length - 2] + nums[nums.Length - 3] - target);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                var j = 1;
                while (i + j + 1 < nums.Length)
                {
                    cloest = Math.Min(Math.Abs(nums[i] + nums[i + j] + nums[i + j + 1] - target), cloest);
                    j++;
                }
            }
            return cloest + target;
        }
    }
}
