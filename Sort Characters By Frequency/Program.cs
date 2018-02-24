using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Characters_By_Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = FrequencySort("");
            Console.WriteLine(r);

            Console.ReadLine();
        }

        // Time Limit Exceeded
        public static string FrequencySort(string s)
        {
            var r = string.Empty;

            Dictionary<char, int> dic = new Dictionary<char, int>();

            //List<string> bucket
            return r;
        }
    }
}
