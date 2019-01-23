using System;

namespace Largest_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int[] nums = new int[] { 3, 30, 34, 5, 9 };

            LargestNumber(nums);

            Console.ReadLine();
        }


        public static string LargestNumber(int[] nums)
        {
            var result = "";
            string[] str_nums = new string[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                str_nums[i] = nums[i].ToString();
            }

            Array.Sort(str_nums, CompareTwoString);

            if (str_nums[0].StartsWith('0'))
            {
                return "0";
            }

            foreach (var item in str_nums)
            {
                //Console.WriteLine(item);

                result += item;
            }

            return result;
        }

        public static int CompareTwoString(string x, string y)
        {
            var str1 = x + y;
            var str2 = y + x;
            return str2.CompareTo(str1);
            //return y.CompareTo(x);
        }


    }
}
