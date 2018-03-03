using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Insert_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 5, 6 };
            Console.WriteLine(SerachInsert(nums, 2));
            Console.ReadLine();
        }

        public static int SerachInsert(int[] nums, int target)
        {
            var pos = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                if (target <= nums[i])
                {
                    return target = i;
                }
            }

            return pos;

        }

    }
}
