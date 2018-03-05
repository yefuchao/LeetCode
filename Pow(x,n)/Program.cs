using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pow_x_n_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyPow(2, 10));

            Console.ReadLine();
        }

        public static double MyPow(double x, int n)
        {
            long N = n;

            if (N < 0)
            {
                x = 1 / x;
                N = -N;
            }

            double ans = 1.0;

            double current = x;

            for (long i = N; i > 0; i /= 2)
            {
                if (i % 2 == 1)
                {
                    ans = ans * current;
                }

                current *= current;
            }

            return ans;


        }

    }
}
