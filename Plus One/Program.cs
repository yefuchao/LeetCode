using System;

namespace Plus_One
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("Hello World!");
        }

        public static int[] PlusOne(int[] digits)
        {
            var len = digits.Length;

            for (int i = len - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }

            int[] newNumber = new int[len + 1];

            newNumber[0] = 1;

            return newNumber;
        }
    }
}
