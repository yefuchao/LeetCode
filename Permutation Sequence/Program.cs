using System;
using System.Collections.Generic;
using System.Text;

namespace Permutation_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalNumber(4, 23));

            Console.ReadLine();
        }

        static int[] mark;
        static int len;
        private static List<string> targets = new List<string>();

        public static string CalNumber(int n, int k)
        {
            StringBuilder sb = new StringBuilder();
            int[] store = new int[n + 1];
            List<int> list = new List<int>();

            store[0] = 1;
            for (int i = 1; i <= n; i++)
            {
                store[i] = store[i - 1] * i;
                list.Add(i);
            }

            //计算每一位的数字
            for (int i = n - 1; i >= 0; i--)
            {
                int index = k % store[i] == 0 ? k / store[i] - 1 : k / store[i];
                sb.Append(list[index]);
                list.RemoveAt(index);
                k -= store[i] * index;
            }

            return sb.ToString();
        }

        //超时
        public static string GetPermutation(int n, int k)
        {
            mark = new int[n];
            len = n;

            BackTracking("");

            return targets[k - 1];
        }

        public static void BackTracking(string target)
        {
            if (len == target.Length)
            {
                targets.Add(target);
            }

            for (int i = 0; i < len; i++)
            {
                if (mark[i] == 0)
                {
                    target += i + 1;
                    mark[i] = 1;
                    BackTracking(target);
                    mark[i] = 0;
                    target = target.Substring(0, target.Length - 1);
                }
            }
        }
    }
}
