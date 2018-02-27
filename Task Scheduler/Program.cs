using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Scheduler
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
        }

        public static int LeastInterval(char[] tasks, int n)
        {
            int[] map = new int[26];

            for (int i = 0; i < tasks.Length; i++)
            {
                map[tasks[i] - 'A']++;
            }

            Array.Sort(map);

            int max_val = map[25] - 1;

            int idle_slots = max_val * n;

            for (int i = 24; i >= 0 && map[i] > 0; i--)
            {
                idle_slots -= Math.Min(map[i], max_val);
            }

            return idle_slots > 0 ? idle_slots + tasks.Length : tasks.Length;
        }

        public static int LastInterval_Quick(char[] tasks,int n)
        {
            int[] c = new int[26];

            for (int i = 0; i < tasks.Length; i++)
            {
                c[tasks[i] - 'A']++;
            }

            Array.Sort(c);

            int j = 24;

            while (j >= 0)
            {
                if (c[25] != c[j])
                {
                    break;
                }
                j--;
            }

            return Math.Max((n + 1) * (c[25] - 1) + 25 - j, tasks.Length);
        }
    }
}
