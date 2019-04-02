using System;

namespace Decode_Ways
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int NumDecodings(string s)
        {
            var ways = 0;

            var nums = s.ToCharArray();

            var preChar = '0';

            for (int i = 0; i < nums.Length; i++)
            {

            }

            return ways;
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
