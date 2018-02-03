using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "abcdef", "abcdfr", "abc" };

            Console.WriteLine(LongestCommonPrefix(strs));

            Console.ReadLine();
        }

        public static string LongestCommonPrefix(string[] strs)
        {

            if (strs.Count() == 0)
            {
                return "";
            }

            var str = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                str = FindTwoStringCommonPrefix(str, strs[i]);
            }

            return str;
        }

        public static string FindTwoStringCommonPrefix(string str1, string str2)
        {
            var str = String.Empty;

            var len = Math.Min(str1.Length, str2.Length);

            for (int i = 0; i < len; i++)
            {
                if (str1[i] == str2[i])
                {
                    str += str1[i];
                }
                else
                {
                    break;
                }
            }

            return str;
        }
    }
}
