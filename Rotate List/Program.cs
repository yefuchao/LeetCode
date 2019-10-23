using System;

namespace Rotate_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ListNode l = new ListNode(1);
            l.next = new ListNode(2);
            l.next.next = new ListNode(3);
            l.next.next.next = new ListNode(4);
            l.next.next.next.next = new ListNode(5);

            var r =  RotateRight(l, 2);

            Console.ReadKey();
        }

        public static ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
            {
                return null;
            }

            if (head.next == null)
            {
                return head;
            }

            ListNode old_tail = head;

            int n;

            for (n = 1; old_tail.next != null; n++)
            {
                old_tail = old_tail.next;
            }

            old_tail.next = head;

            ListNode new_tail = head;
            for (int i = 0; i < n - k % n - 1; i++)
            {
                new_tail = new_tail.next;
            }

            ListNode new_head = new_tail.next;

            new_tail.next = null;


            return new_head;

        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}