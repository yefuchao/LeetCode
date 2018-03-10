using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_Time_to_Buy_and_Sell_Stock_III
{
    class Program
    {
        static void Main(string[] args)
        {
            //1, 2, 4, 2, 5, 7, 2, 4, 9, 0
            //
            int[] prices = { 2, 6, 8, 7, 8, 7, 9, 4, 1, 2, 4, 5, 8 };

            Console.WriteLine(MaxProfit(prices));

            Console.ReadLine();
        }

        public static int MaxProfit(int[] prices)
        {
            int oneBuy = int.MinValue;
            int oneBuyOneSell = 0;
            int twoBuy = int.MinValue;
            int twoBuyTwoSell = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                oneBuy = Math.Max(oneBuy, -prices[i]);
                oneBuyOneSell = Math.Max(oneBuyOneSell, oneBuy + prices[i]);
                twoBuy = Math.Max(twoBuy, oneBuyOneSell - prices[i]);
                twoBuyTwoSell = Math.Max(twoBuyTwoSell, prices[i] + twoBuy);
            }

            return Math.Max(oneBuyOneSell, twoBuyTwoSell);
        }


    }
}
