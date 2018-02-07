using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_strStr__
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = StrStr("", "a");
        }

        public static int StrStr(string haystack, string needle)
        {
            if (haystack == needle)
            {
                return 0;
            }

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
