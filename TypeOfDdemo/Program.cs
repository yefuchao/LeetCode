using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfDdemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write(DetectCapitalUse("SUA"));

            Console.ReadLine();
        }

        public static bool DetectCapitalUse(string word)
        {
            var array = word.ToCharArray();

            var fistCaptial = false;
            bool sendCaptial = false;

            if (array.Length == 1)
            {
                return true;
            }

            if (array.Length > 0)
            {
                if (array[0] >= 65 && array[0] <= 90)
                {
                    fistCaptial = true;
                }
            }

            if (fistCaptial)
            {
                if (array[1] >= 65 && array[1] <= 90)
                {
                    sendCaptial = true;
                }

                if (sendCaptial)
                {
                    for (int i = 2; i < array.Length; i++)
                    {
                        if (array[i] < 65 || array[i] > 90)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    for (int i = 2; i < array.Length; i++)
                    {
                        if (array[i] < 97 || array[i] > 122)
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < 97 || array[i] > 122)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
