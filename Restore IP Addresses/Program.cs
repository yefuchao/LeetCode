using System;
using System.Collections.Generic;
using System.Text;

namespace Restore_IP_Addresses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var r = RestoreIpAddresses("abc1");

            Console.WriteLine(r.Count);

            foreach (var item in r)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
        public static IList<string> RestoreIpAddresses(string S)
        {

            var list = new List<string>();

            list.Add("");

            return DoTrans(S, Encoding.ASCII.GetBytes(S), 0, list);

            //Console.Write(byt.Length);

            //List<String> solutions = new List<string>();
            //restoreIp(s, solutions, 0, "", 0);
            //return solutions;

            //return list;
        }

        private static List<string> DoTrans(string s, byte[] bytes, int index, List<string> pre)
        {
            var list = new List<string>();

            if (bytes.Length == index)
            {
                return pre;
            }

            foreach (var item in pre)
            {
                list.Add(item + s[index].ToString());

                if ((bytes[index] >= 65 && bytes[index] <= 90))
                {
                    list.Add(item + s[index].ToString().ToLower());
                }
                else if ((bytes[index] >= 97 && bytes[index] <= 122))
                {
                    list.Add(item + s[index].ToString().ToUpper());
                }
            }

            return DoTrans(s, bytes, index + 1, list);
        }

        private static void restoreIp(String ip, List<String> solutions, int idx, String restored, int count)

        {
            if (count > 4) return;
            if (count == 4 && idx == ip.Length) solutions.Add(restored);

            for (int i = 1; i < 4; i++)
            {
                if (idx + i > ip.Length) break;
                String s = ip.Substring(idx, idx + i);
                if ((s.StartsWith("0") && s.Length > 1) || (i == 3 && int.Parse(s) >= 256)) continue;
                restoreIp(ip, solutions, idx + i, restored + s + (count == 3 ? "" : "."), count + 1);
            }
        }

    }
}
