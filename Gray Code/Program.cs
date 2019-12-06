using System;
using System.Collections.Generic;

namespace Gray_Code
{
    class Program
    {
        //Wrong answer
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var t = GrayCode(3);

            foreach (var item in t)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        static int[] twopower;
        static IList<int> list = new List<int>();
        public static IList<int> GrayCode(int n)
        {
            if (n == 0)
            {
                return list;
            }
            twopower = new int[n];

            twopower[0] = 1;
            for (int i = 1; i < n; i++)
            {
                twopower[i] = twopower[i - 1] * 2;
            }

            BackTracking(0, new Stack<int>());

            return list;
        }

        public static void BackTracking(int index, Stack<int> stack)
        {
            if (stack.Count == twopower.Length)
            {
                list.Add(GetNumber(stack.ToArray()));
                return;
            }

            stack.Push(0);
            BackTracking(index + 1, stack);
            stack.Pop();
            stack.Push(1);
            BackTracking(index + 1, stack);
            stack.Pop();
        }

        public static int GetNumber(int[] number)
        {
            var n = 0;
            int c = 0;
            for (int i = 0; i < number.Length; i++)
            {
                n += twopower[c] * number[i];
                c++;
            }


            return n;
        }
    }
}
