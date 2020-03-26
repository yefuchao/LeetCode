using System;
using System.Diagnostics;

namespace Longest_Palindromic_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ForcelongestPalindrome("bababbad"));

            Console.WriteLine(LongestPaondrome("bababbad"));

            //Console.ReadLine();
        }

        public static string ForcelongestPalindrome(string s)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            string longSub = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = s.Length - 1; j >= i; j--)
                {
                    var sub = s.Substring(i, j - i);

                    if (IsPalindrome(sub))
                    {
                        if (sub.Length > longSub.Length)
                        {
                            longSub = sub;
                        }

                        break;
                    }
                }
            }

            Console.WriteLine(stopwatch.Elapsed);

            return longSub;
        }

        public static string LongestPaondrome(string s)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            string longSub = string.Empty;


          
            Console.WriteLine(stopwatch.Elapsed);

            return longSub;
        }

        public static bool IsPalindrome(string s)
        {
            int x = 0;
            int y = s.Length - 1;

            while (x <= y)
            {
                if (s[x++] != s[y--])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
