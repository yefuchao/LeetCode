using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates_from_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int RemoveDuplicates(int[] nums)
        {
            Array.Sort(nums);

            if (nums.Length == 0 || nums.Length == 1)
            {
                return nums.Length;
            }

            var j = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[j])
                {
                    j++;
                    nums[j] = nums[i];
                }
            }

            return j + 1;
        }
    }
}
