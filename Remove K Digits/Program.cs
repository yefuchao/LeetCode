using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Remove_K_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine(Removedigits("1432219", 3));
            Console.WriteLine(Removedigits("1111111", 3));
            Console.WriteLine(Removedigits("2111111", 3));
            Console.WriteLine(Removedigits("1111313", 3));
            Console.WriteLine(Removedigits("10", 3));
            Console.ReadLine();
        }

        //Use Stack
        public static string Removedigits(string num, int k)
        {

            var stack = new Stack<char>();

            for (int i = 0; i < num.Length; i++)
            {
                while (stack.Count != 0 && k > 0 && stack.Peek() > num[i])
                {
                    stack.Pop();
                    k--;
                }
                stack.Push(num[i]);
            }

            while (stack.Count != 0 && k > 0)
            {
                stack.Pop();
                k--;
            }

            var list = new List<char>();

            while (stack.Count != 0)
            {
                list.Add(stack.Pop());
            }

            list.Reverse();

            var sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                if (sb.Length == 0 && list[i] == '0')
                {
                    continue;
                }
                sb.Append(list[i]);
            }

            if (sb.Length == 0)
            {
                sb.Append('0');
            }

            return sb.ToString();

        }
    }
}
