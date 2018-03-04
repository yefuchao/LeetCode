using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_in_Rotated_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int Search(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }
            }

            return -1;

        }

        public int SearchQucik(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            return BinarySearch(nums, target, 0, nums.Length - 1);
        }

        private int BinarySearch(int[] nums, int target, int low, int high)
        {
            if (low > high)
                return -1;

            int mid = low + (high - low) / 2;

            if (nums[mid] == target)
                return mid;

            if (nums[low] <= nums[mid])
            {
                if (target < nums[mid] && target >= nums[low])
                    return BinarySearch(nums, target, low, mid - 1);

                return BinarySearch(nums, target, mid + 1, high);
            }

            if (target <= nums[high] && target > nums[mid])
            {
                return BinarySearch(nums, target, mid + 1, high);
            }

            return BinarySearch(nums, target, low, mid - 1);
        }
    }
}
