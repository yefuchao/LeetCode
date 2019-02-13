﻿using System;

namespace Sort_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ListNode head = new ListNode(4)
            {
                next = new ListNode(2)
            };
            head.next.next = new ListNode(1)
            {
                next = new ListNode(3)
            };

            var value = SortList(head);

            while (value != null)
            {
                Console.WriteLine(value.val);
                value = value.next;
            }

            Console.ReadLine();
        }


        public class ListNode
        {
            public int val;

            public ListNode next;

            public ListNode(int x) { val = x; }
        }

        public static ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode prev = null, slow = head, fast = head;

            while (fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            prev.next = null;

            ListNode l1 = SortList(head);
            ListNode l2 = SortList(slow);

            return Merge(l1, l2);

        }

        static ListNode Merge(ListNode l1, ListNode l2)
        {
            ListNode l = new ListNode(0), p = l;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    p.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    p.next = l2;
                    l2 = l2.next;
                }
            }

            if (l1 != null)
            {
                p.next = l1;
            }
            if (l2 != null)
            {
                p.next = l2;
            }

            return l.next;
        }
    }
}