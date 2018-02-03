using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = LetterCombinations("23");
            Console.ReadLine();
        }

        //todo NOT Recursive

        /// <summary>
        /// Recursive
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static List<string> TwoLetterCombinations(List<string> a, string b)
        {
            var res = new List<string>();
            for (int i = 0; i < b.Length; i++)
            {
                if (a.Count > 0)
                {
                    for (int j = 0; j < a.Count; j++)
                    {
                        res.Add(a[j] + b[i].ToString());
                    }
                }
                else
                {
                    res.Add(b[i].ToString());
                }

            }
            return res;
        }

        public static IList<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();

            List<string> letters = new List<string> { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

            for (int i = 0; i < digits.Length; i++)
            {
                var cur = digits[i].ToString();

                var pos = Convert.ToInt32(cur);

                var value = letters[pos];

                result = TwoLetterCombinations(result, value);
            }

            return result;
        }


    }
}
