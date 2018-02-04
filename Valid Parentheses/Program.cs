using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "}]}()){{)[{[(]";

            Console.WriteLine(IsVaild(s));

            Console.ReadLine();
        }

        public static bool IsVaild(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            if (s.Length % 2 != 0)
            {
                return false;
            }

            Stack<string> stack = new Stack<string>();

            stack.Push(s[0].ToString());

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i].ToString() == "(" || s[i].ToString() == "[" || s[i].ToString() == "{")
                {
                    stack.Push(s[i].ToString());
                }
                else
                {
                    var t = stack.Pop();

                    if (t == "(")
                    {
                        if (s[i].ToString() != ")")
                        {
                            return false;
                        }
                    }
                    else if (t == "[")
                    {
                        if (s[i].ToString() != "]")
                        {
                            return false;
                        }
                    }
                    else if (t == "{")
                    {
                        if (s[i].ToString() != "}")
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }


                }
            }

            return stack.Count == 0;
        }
    }
}
