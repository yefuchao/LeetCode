using System;

namespace Prime_Arrangements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(NumPrimeArrangements(100));
            //Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        public static int NumPrimeArrangements(int n)
        {
            long count = 1;

            if (n <= 2)
            {
                return 1;
            }

            int primeNumber = 0;

            for (int i = 1; i < n; i++)
            {
                if (IsPrimer(i))
                {
                    primeNumber++;
                }
            }

            int unPrime = n - primeNumber;

            while (primeNumber > 0)
            {
                count = (count * primeNumber) % 1000000007;
                primeNumber--;
            }

            while (unPrime > 0)
            {
                count = (count * unPrime) % 1000000007;
                unPrime--;
            }

            return (int)count;
        }

        private static bool IsPrimer(int x)
        {
            if (x == 1)
            {
                return false;
            }
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
