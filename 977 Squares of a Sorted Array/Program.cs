using System;

namespace _977_Squares_of_a_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] SortedSquares(int[] A)
        {
            if (A.Length == 0)
            {
                return A;
            }

            int first = 0;
            int last = A.Length - 1;
            int[] B = new int[A.Length];
            var current = last;
            while (last >= first)
            {
                if (A[first] * A[first] > A[last] * A[last])
                {
                    B[current--] = A[first] * A[first];
                    first++;
                }
                else
                {
                    B[current--] = A[last] * A[last];
                    last--;
                }
            }

            return B;
        }
    }
}
