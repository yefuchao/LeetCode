using System;

namespace Linked_List_Cycle_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class ListNode
        {
            public int val { get; set; }

            public ListNode next { get; set; }

            public ListNode(int x)
            {
                val = x;
            }
        }
    }
}
