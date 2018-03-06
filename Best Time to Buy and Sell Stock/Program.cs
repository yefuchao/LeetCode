using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_Time_to_Buy_and_Sell_Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 7, 1, 5, 3, 6, 4 };

            int[] prices = { 7, 6, 5, 4, 3, 2, 1 };


            Console.WriteLine(MaxProfit(nums));
            Console.WriteLine(MaxProfit(prices));

            Console.ReadLine();
        }

        public static int MaxProfit(int[] prices)
        {
            var max = 0;

            if (prices.Length == 0)
            {
                return 0;
            }

            var low = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                max = Math.Max(prices[i] - low, max);

                low = Math.Min(low, prices[i]);
            }

            return max;
        }
    }
}
