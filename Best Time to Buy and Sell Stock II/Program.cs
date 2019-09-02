using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_Time_to_Buy_and_Sell_Stock_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 1, 2, 3, 4, 5 };

            Console.WriteLine(MaxProfit2(prices));

            Console.ReadLine();
        }


        public static int MaxProfit2(int[] prices)
        {
            int len = prices.Length;
            if (len < 2)
            {
                return 0;
            }

            int maxpro = 0;
            for (int i = 1; i < len; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    maxpro += prices[i] - prices[i - 1];
                }
            }

            return maxpro;
        }

        public static int MaxProfit(int[] prices)
        {

            if (prices.Length < 2)
            {
                return 0;
            }

            int max = 0;

            bool hasStock = false;

            for (int i = 1; i < prices.Length; i++)
            {
                if (hasStock)
                {
                    if (prices[i] < prices[i - 1])
                    {
                        max += prices[i - 1];
                        hasStock = false;
                    }
                }
                else
                {
                    if (prices[i] > prices[i - 1])
                    {
                        max -= prices[i - 1];
                        hasStock = true;
                    }
                }
            }


            if (hasStock)
            {
                max += prices[prices.Length - 1];
            }

            return max;
        }
    }
}
