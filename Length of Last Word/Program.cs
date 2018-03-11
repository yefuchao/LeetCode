using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Length_of_Last_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLastWord("a"));

            Console.ReadLine();
        }

        public static int LengthOfLastWord(string s)
        {
            int len = 0;
            int tail = s.Length - 1;

            while (tail >=0 && s[tail] ==' ')
            {
                tail--;
            }

            while (tail >=0 && s[tail]!= ' ')
            {
                len++;
                tail--;
            }

            return len;
        }
    }
}
