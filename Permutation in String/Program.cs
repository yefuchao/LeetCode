using System;

namespace 
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "";
            string s2 = "";

            Console.WriteLine(CheckInclusion(s1, s2));

            Console.ReadKey();

        }

        /// <summary>
        /// 改进：其实不必每次从新计算，s2每次向后，只需要加新进入范围的字符，减去最前面的字符
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool CheckInclusion(string s1, string s2)
        {
            int[] nums = new int[26];

            for (int i = 0; i < s1.Length; i++)
            {
                nums[s1[i] - 'a'] += 1;
            }

            for (int i = 0; i < s2.Length - s1.Length + 1; i++)
            {
                int[] store = new int[26];

                for (int j = i; j < i + s1.Length; j++)
                {
                    store[s2[j] - 'a'] += 1;
                }

                for (int k = 0; k < 26; k++)
                {
                    if (nums[k] != store[k])
                    {
                        break;
                    }

                    if (k == 25)
                    {
                        return true;
                    }
                }
            }

            return false;

        }
    }
}
