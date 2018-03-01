using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MySqrt(10));

            Console.ReadLine();
        }

        public static int MySqrt(int x)
        {
            int left = 1, right = x;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (mid == x / mid)
                {
                    return mid;
                }
                else if (mid < x / mid)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return right;
        }
        
    }
}
