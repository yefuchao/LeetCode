using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            GroupAnagrams(strs);

            Console.ReadKey();
        }

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> dic = new Dictionary<string, IList<string>>();

            foreach (var item in strs)
            {
                var arr = item.ToCharArray();

                Array.Sort(arr);

                var key = string.Join("", arr);

                if (dic.ContainsKey(key))
                {
                    dic[key].Add(item);
                }
                else
                {
                    dic.Add(key, new List<string> { item });
                }
            }

            return dic.Values.ToList();
        }
    }
}
