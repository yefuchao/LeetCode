using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Median_of_Two_Sorted_Arrays
{
    /// <summary>
    /// https://leetcode.com/problems/median-of-two-sorted-arrays/description/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = new int[] { 1, 2 };
            int[] num2 = new int[] { 3 };

            Console.WriteLine(FindMedianSortedArrays(num1, num2));

            Console.ReadLine();
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            //思路 每次去掉一个最大值一个最小值

            var length1 = nums1.Length;
            var length2 = nums2.Length;


            var remaing = length1 + length2;

            var L1 = 0;
            var R1 = length1 - 1;
            var L2 = 0;
            var R2 = length2 - 1;

            while (remaing > 2)
            {
                //每次去掉一个最大，一个最小值
                if (L1 <= R1 && L2 <= R2) //两个数组都有值可用
                {
                    if (nums1[L1] <= nums2[L2])
                    {
                        L1++;
                    }
                    else
                    {
                        L2++;
                    }

                    if (nums1[R1] >= nums2[R2])
                    {
                        R1--;
                    }
                    else
                    {
                        R2--;
                    }

                }
                else if (L1 > R1 && L2 <= R2) //数组1没值，数组2 有值
                {
                    L2++;
                    R2--;
                }
                else if (L1 <= R1 && L2 > R2) //数组1有值，数组2 没值
                {
                    L1++;
                    R1--;
                }

                remaing -= 2;
            }

            //计算中值

            if (remaing == 2) //中值是两个值相加除2的情况
            {
                if (L1 == R1 || L2 == R2)
                {
                    return (Convert.ToDouble(nums1[L1]) + Convert.ToDouble(nums2[L2])) / 2;
                }

                if (L1 > R1)
                {
                    return (Convert.ToDouble(nums2[L2]) + Convert.ToDouble(nums2[R2])) / 2;
                }

                if (L2 > R2)
                {
                    return (Convert.ToDouble(nums1[L1]) + Convert.ToDouble(nums1[R1])) / 2;
                }
            }
            else //中值是最后一个值
            {
                if (L1 > R1)
                {
                    return Math.Round(Convert.ToDouble(nums2[L2]), 1);
                }
                else
                {
                    return Math.Round(Convert.ToDouble(nums1[L1]), 1);
                }
            }


            return 0;
        }
    }
}
