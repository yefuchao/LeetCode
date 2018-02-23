using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Characters_By_Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = FrequencySort("aaavbbb");

            Console.WriteLine(t);

            Console.ReadLine();
        }

        //Time Limit Exceeded 
        public static String FrequencySort(string s)
        {
            var t = string.Empty;

            if (s.Length == 0 || s.Length == 1)
            {
                return s;
            }

            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]] += 1;
                }
                else
                {
                    dic.Add(s[i], 1);
                }
            }

            var k = dic.OrderByDescending(p => p.Value).ToList();

            foreach (var item in k)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    t += item.Key;
                }
            }
            return t;
        }
    }
}
