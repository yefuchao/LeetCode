using System;

namespace Diet_Plan_Performance
{
    class Program
    {
        static void Main(string[] args)
        {

            var calories = new int[] { 1, 2, 3, 4, 5 };

            Console.Write(DietPlanPerformance(calories, 1, 3, 3));

            Console.ReadLine();
        }

        /// <summary>
        /// 5174. Diet Plan Performance
        /// </summary>
        /// <param name="calories"></param>
        /// <param name="k"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static int DietPlanPerformance(int[] calories, int k, int lower, int upper)
        {
            var sum = 0;

            var cal = 0;

            var n = calories.Length;

            for (int i = 1; i <= n; i++)
            {
                cal += calories[i - 1];

                if (i >= k)
                {
                    if (cal < lower)
                    {
                        sum--;
                    }
                    else if (cal > upper)
                    {
                        sum++;
                    }

                    cal -= calories[i - k];
                }



            }

            return sum;
        }
    }
}
