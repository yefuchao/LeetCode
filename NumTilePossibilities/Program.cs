using System;
using System.Collections.Generic;

namespace NumTilePossibilities
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Console.WriteLine(NumTilePossibilities2("AAB"));

            Console.ReadLine();
        }

        //Brilliant solution!
        public static int NumTilePossibilities2(string tiles)
        {
            int[] count = new int[26];

            var chararrays = tiles.ToCharArray();

            //统计字母个数
            foreach (var item in chararrays)
            {
                count[item - 'A']++;
            }

            return dfs(count);

        }

        static int dfs(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < 26; i++)
            {
                if (arr[i] == 0) continue;
                sum++;
                arr[i]--;
                sum += dfs(arr);
                arr[i]++;
            }
            return sum;
        }

        //Time Limit Exceeded
        public static int NumTilePossibilities(string tiles)
        {
            var list = new List<string>();

            var chars = tiles.ToCharArray();

            //Array.Sort(chars);

            for (int i = 0; i < chars.Length; i++)
            {
                var curList = new List<string>();
                curList.AddRange(list);

                var cur = chars[i].ToString();

                if (!curList.Contains(cur))
                {
                    curList.Add(cur);
                    //Console.WriteLine(cur);
                }

                foreach (var item in list)
                {
                    for (int j = 0; j <= item.Length; j++)
                    {
                        var newstring = item.Insert(j, cur);

                        if (!curList.Contains(newstring))
                        {
                            curList.Add(newstring);
                            //Console.WriteLine(newstring);
                        }
                    }
                }

                list.Clear();
                list.AddRange(curList);

            }

            return list.Count;
        }
    }
}
