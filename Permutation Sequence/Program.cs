using System;
using System.Text;

namespace Permutation_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPermutation(3, 6));

            Console.ReadLine();
        }

        public static string GetPermutation(int n, int k)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(i + 1);
            }

            int count = Count(n);

            string origin = sb.ToString();

            StringBuilder res = new StringBuilder();

            while (res.Length != n)
            {
                if (k > count)
                {
                    int pos = k / count; //数字位置
                    k = k % count; //从新计算k
                    res.Append(origin[pos]); //加到结果中
                    origin = origin.Remove(pos, 1);  //从字符串在去掉
                }
                else
                {
                    //当前第一个数字
                    res.Append(origin[0]);
                    origin = origin.Remove(0, 1);
                }

                count = Count(origin.Length);
            }

            return Getnumber(sb.ToString(), k);
        }

        public static string Getnumber(string str, int k)
        {
            if (k == 1)
            {
                return str;
            }

            int n = str.Length;
            int c = Count(n);

            if (c == 1)
            {
                //说明只有2位数字了
                return str[1].ToString() + str[0].ToString();
            }

            int pos = k / c;
            k = k % c;

            return str[pos].ToString() + Getnumber(str.Remove(pos, 1), k).ToString();

        }

        public static int Count(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            return (n - 1) * Count(n - 1);

        }
    }
}
