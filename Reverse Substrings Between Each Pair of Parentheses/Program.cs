using System;
using System.Collections;

namespace Reverse_Substrings_Between_Each_Pair_of_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(ReverseParentheses("(ed(et(oc))el)"));

            Console.ReadLine();
        }

        public static string ReverseParentheses(string s)
        {
            Stack stack = new Stack();

            bool reverse = false;

            var schars = s.ToCharArray();

            string ns = "";

            for (int i = 0; i < schars.Length; i++)
            {
                if (schars[i] != ')')
                {
                    stack.Push(schars[i]);
                }
                else
                {
                    reverse = !reverse;

                    char v = (char)stack.Peek();

                    while (v != '(')
                    {
                        if (reverse)
                        {
                            
                        }
                        else
                        {

                        }

                        v = (char)stack.Peek();
                    }
                }
            }

            return ns;
        }
    }
}
