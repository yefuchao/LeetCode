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
            int[] prices = { 2, 6, 8, 7, 8, 7, 9, 4, 1, 2, 4, 5, 8 };

            Console.WriteLine(MaxProfit(prices));

            Console.ReadLine();
        }

        public static int MaxProfit(int[] prices)
        {

            var Max = 0;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                var r = i + 1;
                var pos = r + 1;
                var min = r + 1;
                var max = r;

                Max = Math.Max(Max, prices[r] - prices[i]);

                while (pos < prices.Length)
                {
                    if (prices[pos] > prices[r])
                    {
                        var t = prices[r] - prices[i] + prices[pos] - prices[min] - (prices[pos] - Math.Min(prices[min], prices[i]));
                        if (t < 0)
                        {
                            Max = Math.Max(Max, prices[pos] - Math.Min(prices[min], prices[i]));
                            r = pos;
                            min = pos + 1;
                        }
                        else
                        {
                            Max = Math.Max(Max, prices[r] - prices[i] + prices[pos] - prices[min]);
                        }

                        if (prices[pos] > prices[max])
                        {
                            max = pos;
                        }
                    }
                    else
                    {
                        if (prices[pos] < prices[min])
                        {
                            min = pos;
                        }
                        else if (prices[pos] == prices[min])
                        {
                            min = pos;
                        }

                        if (pos > r + 1)
                        {
                            Max = Math.Max(Max, prices[pos] - prices[min] + prices[r] - prices[i]);
                        }
                    }

                    if (max < pos && max < min)
                    {
                        if (prices[max] > prices[r])
                        {
                            Max = Math.Max(Max, prices[max] - prices[i] + prices[pos] - prices[min]);
                        }
                    }

                    pos++;
                }
            }

            return Max;
        }


    }
}
