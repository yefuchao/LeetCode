using System;
using System.Text;

namespace Multiply_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var t = Multiply("123", "456");

            Console.WriteLine(t);

            Console.ReadKey();
        }

        public static string Multiply(string num1, string num2)
        {
            if (num1.Equals("0") || num2.Equals("0"))
            {
                return "0";
            }

            char[] c1 = num1.ToCharArray();
            char[] c2 = num2.ToCharArray();

            StringBuilder sb = new StringBuilder();

            int[] arr = new int[num1.Length + num2.Length];

            for (int i = c1.Length - 1; i >= 0; i--)
            {
                int n1 = c1[i] - '0';

                for (int j = c2.Length - 1; j >= 0; j--)
                {
                    int n2 = c2[j] - '0';

                    int sum = arr[i + j + 1] + n1 * n2;
                    arr[i + j] += sum / 10;
                    arr[i + j + 1] = sum % 10;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0 && arr[i] == 0)
                {
                    continue;
                }
                sb.Append(arr[i]);
            }

            return sb.ToString().TrimEnd('0');
        }
    }
}
