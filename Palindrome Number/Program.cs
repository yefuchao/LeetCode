using System;

namespace Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var t = IsPalindrome(1);

            Console.WriteLine(t);

            Console.ReadKey();
        }

        private static bool IsPalindrome(int x)
        {

            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int revertedNum = 0;

            while (x > revertedNum)
            {
                revertedNum = revertedNum * 10 + x % 10;
                x /= 10;
            }

            return x == revertedNum || x == revertedNum / 10;
        }

        public static bool IsPalindromes(int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0)) return false;
            if (x < 10) return true;
            int num = x;
            int result = 0;
            while (num / 10 != 0)
            {

                result += num % 10;
                result *= 10;
                num /= 10;
            }
            result += num % 10;
            return (result == x);
        }
    }
}
