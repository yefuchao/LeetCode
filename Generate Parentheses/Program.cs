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
            var t = GenerateParenthesis2(3);

            for (int i = 0; i < t.Count; i++)
            {
                Console.WriteLine(t[i]);
            }
            Console.ReadLine();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static IList<string> GenerateParenthesis2(int n)
        {
            IList<string> list = new List<string>();

            if (n == 0)
            {
                list.Add("");
                return list;
            }

            Next(n - 1, n, new StringBuilder().Append("("), list);

            return list;
        }

        public static void Next(int left, int right, StringBuilder sb, IList<string> list)
        {
            if (left == 0)
            {
                int num = right;
                while (right > 0)
                {
                    sb.Append(")");
                    right--;
                }
                list.Add(sb.ToString());
                sb.Remove(sb.Length - num, num);
                return;
            }

            if (right > left)
            {
                Next(left, right - 1, sb.Append(")"), list);
                sb.Remove(sb.Length - 1, 1);
            }

            Next(left - 1, right, sb.Append("("), list);
            sb.Remove(sb.Length - 1, 1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
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
