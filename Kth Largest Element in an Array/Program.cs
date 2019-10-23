using System;
using System.Collections;

namespace Kth_Largest_Element_in_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = new int[] { 2, 1, 4, 1, 6, 3, 5 };

            var t = FindKthLargest(arr, 2);

            Console.WriteLine(t);

            Console.ReadKey();
        }



        public static int FindKthLargest(int[] nums, int k)
        {
            int[] arr = new int[k];

            int arrStore = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                //如果arr数组没存满,直接将当前数字按大小存到数组中
                if (arrStore < k)
                {
                    int num = nums[i];
                    int step = 0;

                    while (step < arrStore)
                    {
                        if (num > arr[step])
                        {
                            var tmp = arr[step];
                            arr[step] = num;
                            num = tmp;
                        }

                        step++;
                    }

                    arr[arrStore] = num;
                    arrStore++;

                    continue;
                }

                if (arr[k - 1] < nums[i])
                {
                    var num = nums[i];

                    for (int j = 0; j < k; j++)
                    {
                        if (num > arr[j])
                        {
                            var tmp = arr[j];
                            arr[j] = num;
                            num = tmp;
                        }
                    }

                }
            }


            return arr[k - 1];

        }


    }
}
