using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = GenerateParenthesis(4);

            for (int i = 0; i < t.Count; i++)
            {
                Console.WriteLine(t[i]);
            }
            Console.ReadLine();
        }

        public static IList<string> GenerateParenthesis(int n)
        {
            IList<string> list = new List<string>();

            if (n == 0)
            {
                list.Add("");
            }

            if (n == 1)
            {
                list.Add("()");
            }

            if (n > 1)
            {

                var t = GenerateParenthesis(n - 1);

                for (int k = 0; k < t.Count; k++)
                {
                    var len = t[k].Length;

                    for (int j = 0; j < len; j++)
                    {
                        var q = t[k].Insert(j, "()");

                        if (!list.Contains(q))
                        {
                            list.Add(q);
                        }
                    }
                }
            }

            return list;
        }


    }
}
