using System;

namespace Maximum_Subarray_Sum_with_One_Deletion
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 3, -4, -4, 2, 5, -1, 5 };

            Console.WriteLine(MaximumSum2(arr));

            Console.ReadLine();

            Console.WriteLine("Hello World!");
        }

        public static int MaximumSum(int[] arr)
        {
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                var sum = arr[i];
                var min = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < 0)
                    {
                        min = Math.Min(arr[j], min);
                    }

                    sum += arr[j];

                    max = Math.Max(max, sum - min);
                }

                max = Math.Max(max, sum);
            }

            return max;
        }

        public static int MaximumSum2(int[] arr)
        {
            int max = arr[0];
            var min = 0;

            var pre = new int[arr.Length];

            pre[0] = max;

            for (int i = 1; i < arr.Length; i++)
            {
                var cur = arr[i];



                pre[i] = Math.Max(cur, pre[i - 1] + cur);

                if (pre[i] > max)
                {
                    max = pre[i];

                    if (pre[i] < 0)
                    {
                        min = Math.Min(min, pre[i]);
                    }
                   
                }

            }

            return max;
        }
    }
}
