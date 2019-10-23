using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = PermuteWay2(new int[] { 1, 2, 3 });

            Console.WriteLine(list.Count());
            Console.ReadLine();
        }

        /// <summary>
        /// 46. Permutations
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> Permute(int[] nums)
        {
            List<IList<int>> list = new List<IList<int>>();

            if (nums.Length == 0)
            {
                return list;
            }

            list.Add(new List<int> { nums[0] });

            for (int i = 1; i < nums.Length; i++)
            {
                var temp = new List<IList<int>>();
                temp.AddRange(list);
                list.Clear();

                foreach (var item in temp)
                {
                    for (int pos = 0; pos <= item.Count; pos++)
                    {
                        var cur = new List<int>();
                        cur.AddRange(item);
                        cur.Insert(pos, nums[i]);
                        list.Add(cur);
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// 47. Permutations II
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> PermuteUnique(int[] nums)
        {
            //计算数字个数

            var dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]] += 1;
                }
                else
                {
                    dic.Add(nums[i], 1);
                }
            }

            return Count(dic);
        }

        public static IList<IList<int>> Count(Dictionary<int, int> dic)
        {
            var list = new List<IList<int>>();

            if (dic.Keys.Count() == 1)
            {
                IList<int> sublist = new List<int>();

                for (int i = 0; i < dic.First().Value; i++)
                {
                    sublist.Add(dic.First().Key);
                }

                list.Add(sublist);
            }
            else
            {
                var keys = dic.Keys;

                var arrays = keys.ToArray();

                foreach (var key in arrays)
                {
                    if (dic[key] - 1 == 0)
                    {
                        dic.Remove(key);

                        var subs = Count(dic);

                        foreach (var sub in subs)
                        {
                            sub.Add(key);
                            list.Add(sub);
                        }

                        dic.Add(key, 1);
                    }
                    else
                    {
                        dic[key] -= 1;
                        var subs = Count(dic);

                        foreach (var sub in subs)
                        {
                            sub.Add(key);
                            list.Add(sub);
                        }

                        dic[key] += 1;
                    }
                }
            }

            return list;
        }

        public static IList<IList<int>> PermuteWay2(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();

            IList<int> array = new List<int>();
            PermuteBackTracking(nums, new int[nums.Length], array, res);

            return res;
        }

        public static void PermuteBackTracking(int[] nums, int[] visited, IList<int> array, IList<IList<int>> res)
        {
            if (array.Count == nums.Length)
            {
                //必须重新定义对象，否则后面对array值得修改会影响结果里得对象
                var r = new List<int>();
                r.AddRange(array);
                res.Add(r);
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (visited[i] == 1)
                {
                    continue;
                }

                visited[i] = 1;
                array.Add(nums[i]);
                PermuteBackTracking(nums, visited, array, res);
                visited[i] = 0;
                array.RemoveAt(array.Count - 1);
            }
        }
    }
}
