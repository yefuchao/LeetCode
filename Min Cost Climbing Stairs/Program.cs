using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Cost_Climbing_Stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cost = { 10, 15, 20 };

            // Console.WriteLine(MinCostClimbingStairs(cost));

            int[] costanother = { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };

            Console.WriteLine(MinCostClimbingStairs(costanother));

            Console.ReadLine();
        }

        public static int MinCostClimbingStairs(int[] cost)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            if (cost.Length == 0)
            {
                return 0;
            }

            if (cost.Length == 1)
            {
                return cost[0];
            }

            for (int i = 0; i < cost.Length; i++)
            {
                if (i < 2)
                {
                    dic.Add(i, cost[i]);
                }

                if (i > 1)
                {
                    dic.Add(i, Math.Min(dic[i - 1] + cost[i], dic[i - 2] + cost[i]));
                }
            }

            return Math.Min(dic[cost.Length - 1], dic[cost.Length - 2]);
        }
    }
}
