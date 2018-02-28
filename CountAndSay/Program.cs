using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_And_Say
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountAndSay(5));
            Console.ReadLine();
        }

        public static string CountAndSay(int n)
        {
            if (n == 0)
            {
                return "";
            }

            if (n > 1)
            {
                var val = "";

                var pre = CountAndSay(n - 1);

                var arrays = pre.ToCharArray();

                var startindex = 0;

                var lastindex = 1;

                while (arrays.Length - startindex > 1)
                {
                    while (arrays.Length - lastindex > 0 && arrays[startindex] == arrays[lastindex])
                    {
                        lastindex++;
                    }

                    val += (lastindex - startindex).ToString() + arrays[startindex].ToString();

                    startindex = lastindex;
                }

                if (startindex == arrays.Length - 1)
                {
                    val += "1" + arrays[startindex];
                }

                return val;
            }
            else
            {
                return "1";
            }
        }
    }
}
