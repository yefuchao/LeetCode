using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 2, 3 };

            var value = RemoveElement(nums, 3);

            Console.WriteLine(value);

            Console.ReadLine();

        }

        public static int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            int l = nums.Length;

            while (i != l)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[l - 1];
                    nums[l - 1] = val;
                    l--;
                }
                else
                {
                    i++;
                }
            }

            return i;
        }
    }
}
