using System;

namespace Single_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] nums = { 1, 1, 2, 2, 0, -1, -1 };

            Console.WriteLine(SingleNumber(nums));

            Console.ReadLine();

        }

        //Use Exclusive Or

        public static int SingleNumber(int[] nums)
        {
            var a = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                a ^= nums[i];
            }

            return a;
        }
    }
}
