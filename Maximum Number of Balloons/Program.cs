using System;

namespace Maximum_Number_of_Balloons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int MaxNumberOfBalloons(string text)
        {
            // b1 a1 l2 o2 n0 
            var tarchars = new int[5];

            var chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case 'b':
                        tarchars[0] += 1;
                        break;
                    case 'a':
                        tarchars[1] += 1;
                        break;
                    case 'l':
                        tarchars[2] += 1;
                        break;
                    case 'o':
                        tarchars[3] += 1;
                        break;
                    case 'n':
                        tarchars[4] += 1;
                        break;
                    default:
                        break;
                }
            }

            var count = 0;

            while (tarchars[0] > 0 && tarchars[1] > 0 && tarchars[2] > 1 && tarchars[3] > 1 && tarchars[4] > 0)
            {
                count++;
            }

            return count;
        }
    }
}
