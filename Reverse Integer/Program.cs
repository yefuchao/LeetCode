using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(1534236469));

            Console.ReadLine();
        }

        public static Int32 Reverse(Int32 x)
        {
            try
            {

                Int32 value = 0;
                var negative = false;

                if (x < 0)
                {
                    x = -x;
                    negative = true;
                }

                while (x >= 10)
                {
                    checked
                    {
                        value = value * 10 + x % 10 * 10;
                    }
                    x /= 10;
                }

                value += x;

                if (negative)
                {
                    value = -value;
                }

                return value;

            }
            catch (OverflowException)
            {
                return 0;
            }
        }


    }
}
