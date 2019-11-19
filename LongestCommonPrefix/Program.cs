using System;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = new string[] { "flaaa" };

            Console.WriteLine(LongestCommonPrefix(strs));

            Console.ReadKey();
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }

            int index = 0;

            bool loop = true;

            while (loop && index  < strs[0].Length)
            {

                for (int i = 1; i < strs.Length; i++)
                {
                    if(index  >=  strs[i].Length)
                    {
                        loop = false;
                        break;
                    }
                    if (strs[i][index] != strs[i - 1][index])
                    {
                        loop = false;
                        break;
                    }
                }

                if (loop)
                {
                    index++;
                }
                
            }

            return strs[0].Substring(0, index);
        }
    }
}
