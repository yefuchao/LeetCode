using System;
using System.Collections;
using System.Collections.Generic;

namespace Can_Make_Palindrome_from_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "abcda";
            var queries = new int[][] { new int[] { 3, 3, 0 }, new int[] { 1, 2, 0 }, new int[] { 0, 3, 1 }, new int[] { 0, 3, 2 }, new int[] { 0, 4, 1 } };

            var t = CanMakePaliQueries(s, queries);

            Console.ReadKey();

            Console.WriteLine("Hello World!");
        }

        public static IList<bool> CanMakePaliQueries(string s, int[][] queries)
        {
            List<bool> result = new List<bool>(queries.Length);

            for (int i = 0; i < queries.Length; i++)
            {
                var sub = s.Substring(queries[i][0], queries[i][1] - queries[i][0] + 1);

                //计算字串字母个数

                var subChars = sub.ToCharArray();

                var a = new int[26];

                for (int j = 0; j < a.Length; j++)
                {
                    a[j] = 0;
                }

                foreach (var item in subChars)
                {
                    a[item - 97] += 1;
                }

                var onlyone = 0;

                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] % 2 == 1)
                    {
                        onlyone++;
                    }
                }

                result.Add(onlyone / 2 <= queries[i][2]);

            }

            return result;

        }
    }
}
