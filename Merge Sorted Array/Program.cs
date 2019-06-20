using System;

namespace Merge_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Test1 
            var num1 = new int[7] { 1, 2, 5, 8, 0, 0, 0 };
            var num2 = new int[3] { 3, 5, 6 };

            // Merge(num1, 4, num2, 3);

            //Test2 
            var num3 = new int[5] { 1, 2, 4, 5, 0 };
            var num4 = new int[1] { 3 };

            //Merge(num3, 4, num4, 1);

            var num5 = new int[5] { 3, 0, 0, 0, 0 };
            var num6 = new int[4] { 1, 2, 4, 5 };

            Merge(num5, 1, num6, 4);


            Console.ReadLine();

        }

        //1,2,4,5,6,0
        //3
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            Console.Write("num1: ");
            for (int i = 0; i < nums1.Length - 1; i++)
            {
                Console.Write(nums1[i] + " ");
            }

            Console.WriteLine();


            Console.Write("num2: ");
            for (int i = 0; i < nums2.Length-1; i++)
            {
                Console.Write(nums2[i] + " ");
            }

            Console.WriteLine();

            var x = m - 1;
            var y = n - 1;

            var k = m + n - 1;

            while (x >= 0 && y >= 0)
            {
                if (nums1[x] > nums2[y])
                {
                    nums1[k--] = nums1[x--];
                }
                else
                {
                    nums1[k--] = nums2[y--];
                }
            }

            while (y >= 0)
            {
                nums1[k--] = nums2[y--];
            }

            Console.Write("Result:");

            for (int i = 0; i < nums1.Length - 1; i++)
            {
                Console.Write(nums1[i] + " ");
            }

        }
    }
}
