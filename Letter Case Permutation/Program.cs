using System;
using System.Collections.Generic;
using System.Text;

namespace Letter_Case_Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static IList<string> LetterCasePermutation(string S)
        {
            var list = new List<string>();

            list.Add("");

            return DoTrans(S, Encoding.ASCII.GetBytes(S), 0, list);
        }

        private static List<string> DoTrans(string s, byte[] bytes, int index, List<string> pre)
        {
            var list = new List<string>();

            if (bytes.Length == index)
            {
                return pre;
            }

            foreach (var item in pre)
            {
                list.Add(item + s[index].ToString());

                if ((bytes[index] >= 65 && bytes[index] <= 90))
                {
                    list.Add(item + s[index].ToString().ToLower());
                }
                else if ((bytes[index] >= 97 && bytes[index] <= 122))
                {
                    list.Add(item + s[index].ToString().ToUpper());
                }
            }

            return DoTrans(s, bytes, index + 1, list);
        }
    }
}
