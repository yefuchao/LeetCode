using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using ExtensionMethods;

namespace Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WebRequest request = WebRequest.Create("http://manning.com");

            using (WebResponse response = request.GetResponse())
            using (Stream responseSream = response.GetResponseStream())
            using (FileStream output = File.Create("response.dat"))
            {
                responseSream.Copy(output);
            }

            string s = "Hello world";

            int i = s.WordCount();


            int[] nums = { 3, 2, 4 };

            var t = TwoSum(nums, 6);

            Console.WriteLine(t);

            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var map = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];

                if (map.ContainsKey(nums[i]))
                {
                    return new int[] { (int)map[nums[i]], i };
                }

                if (!map.ContainsKey(complement))
                {
                    map.Add(complement, i);
                }
            }

            throw new Exception("Not possible!");
        }
    }
}
