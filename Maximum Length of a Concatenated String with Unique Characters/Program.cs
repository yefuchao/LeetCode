using System;
using System.Collections.Generic;

namespace Maximum_Length_of_a_Concatenated_String_with_Unique_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>
            {
                "un",
                "qi",
                "ue"
            };

            Console.WriteLine(MaxLength(list));

            Console.ReadKey();
        }
        public static int MaxLength(IList<string> arr)
        {
            List<string> store = new List<string>();

            for (int i = 0; i < arr.Count; i++)
            {
                char[] cur = arr[i].ToCharArray();

                Array.Sort(cur);
                bool same = false;
                for (int j = 1; j < cur.Length; j++)
                {
                    if (cur[j] == cur[j - 1])
                    {
                        same = true;
                    }
                }

                if (same)
                {
                    continue;
                }

                for (int j = 0; j < store.Count; j++)
                {
                    for (int k = 0; k < cur.Length; k++)
                    {
                        int pos = store[j].IndexOf(cur[k]);

                        if (pos > -1)
                        {
                            break;
                        }

                        if (k == cur.Length - 1)
                        {
                            string n = store[j] + arr[i];
                            store.Add(n);
                        }
                    }
                }

                store.Add(arr[i]);

            }

            int max = 0;

            for (int i = 0; i < store.Count; i++)
            {
                max = Math.Max(max, store[i].Length);
            }

            return max;
        }

    }
}
