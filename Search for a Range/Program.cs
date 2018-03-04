using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_for_a_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };
            var t = SearchRange(nums, 9);
            Console.WriteLine("done");
            Console.ReadLine();
        }

        public static int[] SearchRange(int[] nums, int target)
        {
            int[] range = new int[] { -1, -1 };

            int leftIndex = extremeInsertionIndex(nums, target, true);

            if (leftIndex == nums.Length || nums[leftIndex] != target)
            {
                return range;
            }

            int rightIndex = extremeInsertionIndex(nums, target, false);

            range[0] = leftIndex;
            range[1] = rightIndex - 1;

            return range;
        }

        public static int extremeInsertionIndex(int[] nums, int target, bool left)
        {
            int low = 0;
            int high = nums.Length;

            while (low < high)
            {
                int mid = (low + high) / 2;

                if (nums[mid] > target || (left && nums[mid] == target))
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return low;
        }

    }
}
