using System;

namespace Target_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1 };
            Console.WriteLine(FindTargetSumWays(nums, 1));
            Console.ReadLine();
        }

        public static int FindTargetSumWays(int[] nums, int S)
        {

            var ways = 0;

            if (nums.Length == 0)
            {
                return ways;
            }

            if (nums.Length == 1)
            {
                if (nums[0] == S)
                {
                    ways += 1;
                }

                if (nums[0] == -S)
                {
                    ways += 1;
                }
            }
            else
            {
                var last = nums[nums.Length - 1];

                var nNums = new int[nums.Length - 1];

                for (int i = 0; i < nNums.Length; i++)
                {
                    nNums[i] = nums[i];
                }

                ways += FindTargetSumWays(nNums, S + last);
                ways += FindTargetSumWays(nNums, S - last);
            }

            return ways;
        }


        public int FindTargetSumWaysFast(int[] nums, int S)
        {
            var sum = 0;
            for (var i = 0; i < nums.Length; i++) sum += nums[i];
            if ((sum - S) % 2 != 0) return 0;
            if (sum < S) return 0;
            var target = (sum - S) / 2;


            var possible = new int[target + 1];
            possible[0] = 1;

            foreach (var num in nums)
            {
                for (var i = possible.Length - num - 1; i >= 0; i--)
                {
                    possible[i + num] += possible[i];
                }
            }

            return possible[possible.Length - 1];
        }

        public int FindTargetSumWayFast2(int[] a, int t)
        {
            //s(p) - s(n) = t
            // 2s(p) = t + totalS( s(p)+s(n) )
            // s(p) = ( t + totalS) / 2

            int totalS = 0;
            foreach (int n in a)
            {
                totalS += n;
            }

            if (totalS < t) return 0;

            int total = t + totalS;

            if (total % 2 != 0) return 0;

            t = total / 2;

            var dp = new int[t + 1];
            dp[0] = 1;
            for (int i = 0; i <= a.Length - 1; i++)
            {
                for (int curT = t; curT >= a[i]; curT--)
                {
                    int preT = curT - a[i];
                    dp[curT] += dp[preT];
                }
            }

            return dp[t];

        }

    }
}
