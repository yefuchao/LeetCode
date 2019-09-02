using System;

namespace Compare_Strings_by_Frequency_of_the_Smallest_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new string[] { "bbb", "cc" };
            var w = new string[] { "a", "aa", "aaa", "aaaa" };

            var a = NumSmallerByFrequency(q, w);

            Console.ReadKey();

            Console.WriteLine("Hello World!");
        }

        public static int[] NumSmallerByFrequency(string[] queries, string[] words)
        {
            var ans = new int[queries.Length];

            var q = new int[queries.Length];
            var w = new int[words.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                q[i] = Helper(queries[i]);
            }

            for (int i = 0; i < words.Length; i++)
            {
                w[i] = Helper(words[i]);
            }


            for (int i = 0; i < q.Length; i++)
            {
                var count = 0;
                for (int k = 0; k < w.Length; k++)
                {
                    if (q[i] < w[k])
                    {
                        count++;
                    }
                }

                ans[i] = count;
            }

            return ans;
        }

        private static int Helper(string word)
        {
            var chars = word.ToCharArray();

            var small = chars[0];
            var total = 1;

            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] < small)
                {
                    small = chars[i];
                    total = 1;
                }
                else if (chars[i] == small)
                {
                    total++;
                }
            }

            return total;
        }
    }
}
