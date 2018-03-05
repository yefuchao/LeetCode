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
            Console.WriteLine(MyPow(2.1000, 3));

            Console.ReadLine();
        }

        public static double MyPow(double x, int n)
        {
            double obj = 1.00000;

            var val = Pow(x, n, x);

            return obj * val;

        }

        public static double Pow(double x, int n, double current)
        {

            if (n / 2 > 1)
            {
                var val = Pow(x, n / 2, current);

                return val;
            }

            return x * x;
        }

    }
}
