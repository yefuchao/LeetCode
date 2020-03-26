using System;

namespace Counting_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] CountBits(int num)
        {
            int[] ans = new int[num + 1];
            ans[0] = 0;

            int sqrt = 1;
            for (int i = 1; i <= num; i++)
            {
                if (i >= sqrt * 2)
                {
                    sqrt = sqrt * 2;
                }
                var k = i - sqrt;
                ans[i] = 1 + ans[k];
            }

            return ans;
        }
    }
}
