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
            var a = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                a = a ^ nums[i];
            }

            return a;
        }
    }
}
