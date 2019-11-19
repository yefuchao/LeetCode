using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Transformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] nums = new int[] { 6, 2, 3, 4 };
            TransformArray(nums);

            Console.ReadLine();
        }
        public static IList<int> TransformArray(int[] arr)
        {
            bool change;
            do
            {
                change = false;

                for (int i = 1; i < arr.Length - 1; i++)
                {

                    if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                    {
                        arr[i] -= 1;
                        change = true;
                    }

                    if (arr[i] < arr[i - 1] && arr[i] < arr[i + 1])
                    {
                        arr[i] += 1;
                        change = true;
                    }
                }
            } while (change);

            return arr.ToList();
        }

    }
}
