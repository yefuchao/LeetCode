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
            int[] prices = { 1, 2, 4, 2, 5, 7, 2, 4, 9, 0 };

            Console.WriteLine(MaxProfit(prices));

            Console.ReadLine();
        }

        public static int MaxProfit(int[] prices)
        {

            var max = 0;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                var r = i + 1;
                var pos = r + 1;
                var min = r + 1;

                max = Math.Max(max, prices[r] - prices[i]);

                while (pos < prices.Length)
                {
                    if (prices[pos] > prices[r])
                    {
                        if (prices[r] < prices[min])
                        {
                            r = pos;
                            min = pos + 1;
                            max = Math.Max(max, prices[r] - prices[i]);
                        }
                        else
                        {
                            max = Math.Max(max, prices[r] - prices[i] + prices[pos] - prices[min]);
                        }
                    }
                    else
                    {
                        if (prices[pos] < prices[min])
                        {
                            min = pos;
                        }

                        if (pos > r + 1)
                        {
                            max = Math.Max(max, prices[pos] - prices[min] + prices[r] - prices[i]);
                        }
                    }

                    pos++;
                }
            }

            return max;
        }


    }
}
