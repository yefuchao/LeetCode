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
            int[] nums = new int[] { 1, 2, 3, 4, 5, 7 };
            Console.WriteLine(SerachInsert(nums, 8));
            Console.ReadLine();
        }

        public static int SerachInsert(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                if (nums[0] >= target)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }

            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                if (target > nums[right])
                {
                    return right + 1;
                }

                if (target < nums[left])
                {
                    return left;
                }

                var mid = left + (right - left) / 2;

                if (target == nums[mid])
                {
                    return mid;
                }
                else if (target > nums[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid + 1;
                }
            }

            return right;

        }

    }
}
