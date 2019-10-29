using System;
using System.Collections.Generic;
using System.Text;

namespace Letter_Combinations_of_a_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            var res = LetterCombinations("34");

            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine(i + ":" + res[i]);
            }

            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }


        public static IList<string> LetterCombinations(string digits)
        {
            char[][] dics = new char[][]
            {
                new char[]{}, //0
                new char[] {},
                new char[]{'a','b','c'},
                new char[]{'d','e','f'},
                new char[] {'g','h','i'},
                new char[]{'j','k','l'},
                new char[]{'m','n','o'},
                new char[] {'p','q','r','s'},
                new char[]{'t','u','v'},
                new char[]{'w','x','y','z'}
            };

            var nums = digits.ToCharArray();

            IList<string> res = new List<string>();

            //FindAllPosiable(nums, dics, new StringBuilder(), res, new int[nums.Length]);

            FindByOrder(nums, dics, new StringBuilder(), res, 0);

            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="dics"></param>
        /// <param name="sb"></param>
        /// <param name="res"></param>
        /// <param name="pos"></param>
        public static void FindByOrder(char[] nums, char[][] dics, StringBuilder sb, IList<string> res, int pos)
        {
            if (sb.Length == nums.Length)
            {
                res.Add(sb.ToString());
                return;
            }

            var words = dics[Convert.ToInt32(nums[pos].ToString())];

            for (int i = 0; i < words.Length; i++)
            {
                sb.Append(words[i]);
                FindByOrder(nums, dics, sb, res, pos + 1);
                sb.Remove(sb.Length - 1, 1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="words"></param>
        /// <param name="sb"></param>
        /// <param name="res"></param>
        /// <param name="visited"></param>
        public static void FindAllPosiable(char[] nums, char[][] dics, StringBuilder sb, IList<string> res, int[] visited)
        {
            if (sb.Length == nums.Length)
            {
                res.Add(sb.ToString());
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (visited[i] == 1)
                {
                    continue;
                }

                visited[i] = 1;

                var num = Convert.ToInt32(nums[i].ToString());

                var words = dics[num];

                for (int j = 0; j < words.Length; j++)
                {
                    sb.Append(words[j]);
                    FindAllPosiable(nums, dics, sb, res, visited);
                    visited[i] = 0;

                    sb.Remove(sb.Length - 1, 1);

                }
            }
        }
    }
}
