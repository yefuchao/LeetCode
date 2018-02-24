using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public int LongestValidParentheses(string s)
        {
            var longest = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ')')
                {
                    continue;
                }

                Stack<char> stack = new Stack<char>();

                stack.Push(s[i]);

                var pos = i + 1;

                if (s.Length - pos <= longest)
                {
                    continue;
                }

                while (pos < s.Length)
                {
                    if (s[pos] == '(')
                    {
                        stack.Push(s[i]);
                    }
                    else if (s[i] == ')' && stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        break;
                    }
                }

                if (stack.Count == 0)
                {

                }
            }

            return longest;
        }
    }
}
