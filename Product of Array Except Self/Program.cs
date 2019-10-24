using System;

namespace Product_of_Array_Except_Self
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4 };
            // 24 ,12 ,8, 6
            var t = ProductExceptSelf(nums);
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);
            }
            Console.ReadKey();

        }

        /// <summary>
        /// 先求左边得积，再求右边得积
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] res = new int[nums.Length];
            int k = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = k;
                k = nums[i] * res[i];
            }
            k = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                res[i] *= k;
                k *= nums[i];
            }

            return res;
        }
    }
}
