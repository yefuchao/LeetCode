using System;
using System.Collections.Generic;

namespace Word_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(WordBreak("leetcode", new List<string> { "leet", "code" }));

            Console.ReadKey();
        }

        public static bool WordBreak(string s, IList<string> wordDict)
        {
            bool[] dp = new bool[s.Length + 1];

            dp[0] = true;

            for (int i = 1; i < s.Length + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (dp[j] == true && wordDict.Contains(s.Substring(j, i - j)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[s.Length];
        }
    }
}